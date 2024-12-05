using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public List<PurchaseItemViewModel> Items { get; set; }
        public string Address { get; set; }
        public OrderStateViewModel State { get; set; }
    }
}
