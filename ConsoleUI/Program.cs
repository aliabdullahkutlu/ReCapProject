using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandAndCarAdded();
            //ColorAddedTest();
            //CarDetailsDTO();
            //CustomerDetailsDTO();
            //RentalDetailsDTO();
        }

        private static void RentalDetailsDTO()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetRentalDetailDto();
            Console.WriteLine("---------KİRALAMA LİSTESİ---------\n ");
            foreach (var rentalDTO in result.Data)
            {
                Console.WriteLine(" Rental Id:  " + rentalDTO.RentalId +
                                  "\n Müşteri Adı : " + rentalDTO.CustomerName +
                                  "\n Arabanın Adı : " + rentalDTO.Description +
                                  "\n Arabanın Günlük Kira Fiyatı :  " + rentalDTO.DailyPrice +
                                  "\n Arabanın Marka Adı :  " + rentalDTO.BrandName +
                                  "\n Arabayı Kiralama Başlangıcı :  " + rentalDTO.RentalStart +
                                  "\n Araba kiralama bitiş tarihi:  " + rentalDTO.RentalEnd +
                                  "\n----------------------------------------");
            }
        }

        private static void CustomerDetailsDTO()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.GetCustomerDetailDto();
            Console.WriteLine("---------MÜŞTERİ LİSTESİ---------\n ");
            foreach (var customerDTO in result.Data)
            {
                Console.WriteLine(" Müşteri Adı : " + customerDTO.CustomerName +
                                  "\n Müşterinin Soyadı :  " + customerDTO.CustomerSurname +
                                  "\n Müşterinin Şirketi :  " + customerDTO.CustomerCompany +
                                  "\n----------------------------------------");

            }
        }

        private static void ColorAddedTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorId = 7, ColorName = "Yeşil" });
        }

        private static void BrandAndCarAdded()
        {
            CarManager carManager = new CarManager(new EfCarDal(), new BrandManager(new EfBrandDal()));
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandId = 9, BrandName = "Toyota" });
            carManager.Add(new Car
            { Id = 8, ColorId = 1, BrandId = 9, DailyPrice = 250, ModelYear = 2011, Description = "Hilux" });
        }

        private static void CarDetailsDTO()
        {
            CarManager carManager = new CarManager(new EfCarDal(), new BrandManager(new EfBrandDal()));
            var result = carManager.GetCarDetailDto();

            Console.WriteLine("---------KİRALIK ARABA LİSTESİ---------\n ");
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(" Arabanın Adı : " + car.Description +
                                      "\n Arabanın Marka Adı :  " + car.BrandName +
                                      "\n Arabanın Günlük Kira Fiyatı :  " + car.DailyPrice +
                                      "\n Arabanın Rengi :  " + car.ColorName +
                                      "\n----------------------------------------");
                }
            }
        }
    }
}
