using CleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Interfaces
{
    public interface ICartService
    {
        void InitializeCart(string userId);
        CartViewModel GetCartByUser(string userId);
        bool AddToCart(CartViewModel cart, ItemViewModel item);
        bool StartOrder(CartViewModel cart);
        void ClearCart(CartViewModel cart);

    }
}
