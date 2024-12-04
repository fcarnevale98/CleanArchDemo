using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<PurchaseItem> Items { get; set; }
        public string Address { get; set; }
        public OrderState State { get; set; }
    }
}
