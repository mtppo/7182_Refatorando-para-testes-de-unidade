using System;

namespace Store.Domain.Entities
{
    public class OrderItem : Entity
    {
        public Product Product { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public OrderItem(Product products, int quantity)
        {
            Product = products;
            Price = Product != null ? products.Price : 0;
            Quantity = quantity;
        }

        public decimal Total()
        {
            return Price * Quantity;
        }
    }
}