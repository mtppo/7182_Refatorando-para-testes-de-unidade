using System;

namespace Store.Domain.Entities
{
    public class OrderIten : Entity
    {
        public Products Product { get; private set; }
        public decimal Price { get; private set; }

        public int Quantity { get; private set; }

        public OrderIten(Products products, decimal price, int quantity)
        {
            
        }

        
    }
}