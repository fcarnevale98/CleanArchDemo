using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanArch.Domain.Interfaces
{
    public interface IItemRepository
    {
        IQueryable<Item> GetItems();
        IQueryable<Item> GetItemsFromSearch(string searchQuery);
        Item GetItemById(int id);
    }
}
