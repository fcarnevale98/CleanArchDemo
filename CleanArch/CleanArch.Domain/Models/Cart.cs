using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Models
{
    public class Cart
    {
        public int Id { get; set; }
        //Provvisoria
        public string UserId { get; set; }
        public List<PurchaseItem> Items { get; set; }
    }
}
