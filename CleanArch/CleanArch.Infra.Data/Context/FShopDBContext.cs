using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Context
{
    public class FShopDBContext : DbContext
    {
        public FShopDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Item> Items { get; set; }
        public DbSet<PurchaseItem> PurchaseItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderState> OrderStates { get; set; }
    }
}
