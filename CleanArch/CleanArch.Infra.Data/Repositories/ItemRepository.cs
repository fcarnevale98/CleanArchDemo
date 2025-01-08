using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;

namespace CleanArch.Infra.Data.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private FShopDBContext _ctx;

        public ItemRepository(FShopDBContext ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<Item> GetItems()
        {
            return _ctx.Items;
        }

        public IQueryable<Item> GetItemsFromSearch(string searchQuery)
        {
            return _ctx.Items.Where( i => i.Name.Contains(searchQuery) );
        }

        public Item GetItemById(int id)
        {
            return _ctx.Items.FirstOrDefault( i => i.Id == id );
        }
    }
}
