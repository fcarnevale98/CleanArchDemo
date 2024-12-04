using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.ViewModels
{
    public class CartViewModel
    {
        public int Id { get; set; }
        public List<PurchaseItemViewModel> Items { get; set; }
    }
}
