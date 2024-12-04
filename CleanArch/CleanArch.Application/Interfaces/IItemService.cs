using CleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Interfaces
{
    public interface IItemService
    {
        IEnumerable<ItemViewModel> GetItems();
        IEnumerable<ItemViewModel> GetItemsFromSearch(string searchQuery);
        ItemViewModel GetItemById(int id);
    }
}
