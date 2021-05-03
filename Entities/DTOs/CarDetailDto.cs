using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        public int CarId { get; set; }
        public string ColorName { get; set; }
        public string BrandName { get; set; }
        public short DailyPrice { get; set; }
        public int ModelYear { get; set; }
        public string Fuel { get; set; }
        public string MotorHacmi { get; set; }
        public int MotorGucu { get; set; }
        public string Vites { get; set; }
        public string ÇekişTürü { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        
    }
}
