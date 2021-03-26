using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constans
{
    public static class Messages     //publicler PascalCase yazılır
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarPriceInValid = "Araba fiyatı 0'dan büyük olmalıdır";
        public static string CarDeleted = "Araba silindi";
        public static string CarCanNotDelete = "araba silinemedi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarCanNotUpdated = "Araba güncellenemedi";
        public static string CarsListed = "Araba listelendi";


        public static string BrandAdded = "Marka eklendi";
        public static string BrandNameInValid = "Marka ismi geçersiz";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandCanNotDeleted = "Marka Silinirken Hata alındı";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandCanNotUpdated = "Marka güncellenemedi";
        public static string BrandsListed = "Markalar listelendi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorCanNotAdded = "Renk eklenemedi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorCanNotDelete = "Renk silinemedi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorCanNotUpdated = "Renk Güncellenemedi";
        public static string ColorsListed = "Renkler listelendi";
        public static string GetColorByColorId = "Renk numara ve isimleriyle listelendi";
        public static string ColorsListedWColorId = "Seçilen rengin arabaları listelendi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerNameInValid = "Müşteri ismi Geçersiz";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerCanNotDeleted = "müşteri silinemedi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerCanNotUpdated = "Müşteri güncellenemedi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string GetCustomerByCustomerId = "müşteriler numara ve isimleriyle listelendi";
        public static string CustomerListedWDto = "Ayrıntılarla listelenen müşteriler";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserCanNotDeleted = "Kullanıcı silinirken hata oluştu";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UsersListed = "Kullanıcılar listelendi";
        public static string UserEmailFormatIsWrong = "Yanlış Email Formatı";
        public static string GetUserByUserId = "Kullanıcı numaralarıyla birlikte kullanıcılar listelendi";

        public static string RentalAdded = "Araç kiralama eklendi";
        public static string RentalDeleted = "Araç kiralama silindi";
        public static string RentalCanNotDelete = "Araç kiralama silinemedi";
        public static string RentalUpdated = "Araç kiralama güncellendi";
        public static string RentalsListed = "Araç kiralamaları listelendi";
        public static string RentalReturnDateNull = "Araç henüz teslim edilmedi";
        public static string GetRentalByRentalId = "Araç kiralamalar numaralarıyla listelendi";

        public static string CarListedWDto = "Arabalar detaylarıyla listelendi";
        public static string CarListedWBrandId = "Seçilen markanın arabaları listelendi";
        public static string CarListedWColorId = "Seçilen renk arabalar listelendi";
        public static string RentalListedWCarAndCustomer = "araç kiralamalar listelendi";

        public static string ImageCanNotAddMoreFive = "Araba için 5'den fazla Resim Eklenemez";
        public static string ImageAdded = "Araba resmi eklendi";
        public static string ImageCanNotFound = "Araba resmi bulunamadı";
        public static string ImageDeleted = "Araba resmi silindi";
        public static string ImageUpdated = "Araba resmi güncellendi";

        public static string Maintenance = "Sistem bakımda";
        public static string GetAll = "listelendi";
        public static string CarCountOfBrandError = "Bir markada en fazla 10 adet araba olabilir";
        public static string BrandLimitExceded = "Marka limiti aşıldığı için yeni araba eklenemiyor";
    }
}
