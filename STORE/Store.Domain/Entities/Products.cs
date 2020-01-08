namespace Store.Domain.Entities
{
    public class Products
    {
        public string Title { get; private set; }
        public decimal Price { get; private set; }
        public bool Active { get; private set; }

        public Products(string title, decimal price, bool active)
        {
            Title = title;
            Price = price;
            Active = active;
        }
    }
}