using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.ViewModels
{
    public class PurchaseItemViewModel
    {
        public int Id { get; set; }
        public ItemViewModel Item { get; set; }
        public int Quantity { get; set; }
    }
}
