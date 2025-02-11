using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Application.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        private readonly IMapper _autoMapper;
        public ItemService(IItemRepository itemRepository, IMapper automapper)
        {
            _itemRepository = itemRepository;
            _autoMapper = automapper;
        }
        public ItemViewModel GetItemById(int id)
        {
            return _itemRepository.GetItemById(id).ProjectTo<ItemViewModel>(_autoMapper.ConfigurationProvider).FirstOrDefault();
        }

        public IEnumerable<ItemViewModel> GetItems()
        {
            return _itemRepository.GetItems().ProjectTo<ItemViewModel>(_autoMapper.ConfigurationProvider);
        }

        public IEnumerable<ItemViewModel> GetItemsFromSearch(string searchQuery)
        {
            return _itemRepository.GetItemsFromSearch(searchQuery).ProjectTo<ItemViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
