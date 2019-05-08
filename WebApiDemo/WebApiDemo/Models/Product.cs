using System;
using System.Collections.Generic;

namespace WebApiDemo.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public DateTime? LaunchDate { get; set; }
        public string Category { get; set; }
        public decimal? Price { get; set; }
    }
}
