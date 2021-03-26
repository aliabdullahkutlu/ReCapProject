using System;
using Core.Entities;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int RentalId { get; set; }
        public string CustomerName { get; set; }
        public string Description { get; set; }
        public decimal DailyPrice { get; set; }
        public string BrandName { get; set; }
        public DateTime RentalStart { get; set; }
        public DateTime? RentalEnd { get; set; }
    }
}