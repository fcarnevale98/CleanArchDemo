using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double StockPrice { get; set; }
        public double Discount { get; set; }
        public int StockQuantity { get; set; }
    }
}
