using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from c in context.Cars

                             join co in context.Colors on c.ColorId equals co.ColorId
                             join b in context.Brands on c.BrandId equals b.BrandId



                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 BrandName = b.BrandName,
                                 DailyPrice = (short)c.DailyPrice,
                                 ColorName = co.ColorName,
                                 Images = (from i in context.CarImages where i.CarId == c.Id select i.ImagePath).ToList(),
                                 //(from carImage in context.CarImages where carImage.CarId == c.Id select carImage.ImagePath).FirstOrDefault(),
                                 Description = c.Description,
                                 //Status = !context.Rentals.Any(r => r.CarId == c.CarId && (r.ReturnDate == null  r.ReturnDate > DateTime.Now))
                                 //IsRentable = !context.Rentals.Any(r=>r.CarId == c.Id)  !context.Rentals.Any(r => r.CarId == c.Id && (r.ReturnDate == null || (r.ReturnDate.HasValue && r.ReturnDate > DateTime.Now )))
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }
    }
}