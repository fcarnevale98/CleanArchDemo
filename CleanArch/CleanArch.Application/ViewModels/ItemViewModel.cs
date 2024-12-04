using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.ViewModels
{
    public class ItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double StockPrice { get; set; }
        public double Discount { get; set; }
    }
}
