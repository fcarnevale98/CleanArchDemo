using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Application.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;
        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }
        public bool AddToCart(CartViewModel cart, ItemViewModel item)
        {
            throw new NotImplementedException();
        }

        public void ClearCart(CartViewModel cart)
        {
            throw new NotImplementedException();
        }

        public CartViewModel GetCartByUser(string userId)
        {
            throw new NotImplementedException();
        }

        public void InitializeCart(string userId)
        {
            //TODO
        }

        public bool StartOrder(CartViewModel cart)
        {
            throw new NotImplementedException();
        }
    }
}
