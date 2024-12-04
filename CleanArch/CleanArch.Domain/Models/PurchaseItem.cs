using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Models
{
    public class PurchaseItem
    {
        public int Id { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
    }
}
