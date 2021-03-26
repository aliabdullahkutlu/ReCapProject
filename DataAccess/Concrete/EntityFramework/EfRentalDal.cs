using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectContext>, IRentalDal
    {

        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result =
                    from r in context.Rentals
                    join c in context.Cars on r.CarId equals c.Id
                    join b in context.Brands on c.BrandId equals b.BrandId

                    join cu in context.Customers on r.CustomerId equals cu.CustomerId
                    join u in context.Users on cu.UserId equals u.UserId

                    select new RentalDetailDto
                    {
                        RentalId = r.RentalId,
                        CustomerName = u.FirstName,
                        Description = c.Description,
                        DailyPrice = (short)c.DailyPrice,
                        BrandName = b.BrandName,
                        RentalStart = r.RentalStart,
                        RentalEnd = r.RentalEnd
                    };
                return result.ToList();
            }
        }

    }
}
