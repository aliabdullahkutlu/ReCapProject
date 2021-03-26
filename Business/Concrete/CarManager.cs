using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IBrandService _brandService;

        public CarManager(ICarDal carDal, IBrandService brandService)
        {
            _carDal = carDal;
            _brandService = brandService;
        }


        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            IResult result = BusinessRules.Run(CheckIfCarCountOfBrandCorrect(car.BrandId), CheckIfCategoryLimitExceded());

            if (result != null)
            {
                return result;
            }

            _carDal.Add(car);

            return new SuccessResult(Messages.CarAdded);

        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == carId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailDto()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), Messages.CarListedWDto);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id), Messages.CarListedWBrandId);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id), Messages.CarListedWColorId);
        }

        
        
        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Car car)
        {
            IResult result = BusinessRules.Run(CheckIfCarCountOfBrandCorrect(car.BrandId), CheckIfCategoryLimitExceded());

            if (result != null) //kurala uymayan bir durum oluşmuş ise 
            {
                return result;
            }

            _carDal.Update(car);

            return new SuccessResult(Messages.CarUpdated);
        }
        
        
        private IResult CheckIfCarCountOfBrandCorrect(int brandId)
        {
            //Select count(*) from cars where brandId=1
            var result = _carDal.GetAll(c => c.BrandId == brandId).Count;
            if (result >= 10)
            {
                return new ErrorResult(Messages.CarCountOfBrandError);
            }
            return new SuccessResult();
        }

        private IResult CheckIfCategoryLimitExceded()
        {
            var result = _brandService.GetAll();
            if (result.Data.Count > 15)
            {
                return new ErrorResult(Messages.BrandLimitExceded);
            }

            return new SuccessResult();
        }
    }
}
