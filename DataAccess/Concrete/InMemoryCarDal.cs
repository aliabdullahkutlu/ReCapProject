using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()  //ctor 
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2015, Description = "Vw Golf VII Mavi", DailyPrice = 230},
                new Car{Id = 2, BrandId = 1, ColorId = 2, ModelYear = 2017, Description = "Vw Passat B8 Beyaz", DailyPrice = 290},
                new Car{Id = 3, BrandId = 2, ColorId = 2, ModelYear = 2016, Description = "Ford Focus Beyaz", DailyPrice = 195},
                new Car{Id = 4, BrandId = 3, ColorId = 3, ModelYear = 2010, Description = "Volvo S60 Siyah", DailyPrice = 142},
                new Car{Id = 5, BrandId = 2, ColorId = 1, ModelYear = 2012, Description = "Vw Polo Mavi", DailyPrice = 175}

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deleteToCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(deleteToCar);
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(Car car)
        {
            return _cars.Where(c => c.Id == c.Id).ToList();
        }

       

        public void Update(Car car)
        {
            Car updateToCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            updateToCar.ColorId = car.ColorId;
            updateToCar.BrandId = car.BrandId;
            updateToCar.DailyPrice = car.DailyPrice;
            updateToCar.ModelYear = car.ModelYear;
            updateToCar.Description = car.Description;
        }
    }
}
