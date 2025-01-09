using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Models;

namespace CleanArch.Domain.Interfaces
{
    public interface ICartRepository
    {
        Cart GetCartById(int id);
        void Add(Cart cart);
    }
}
