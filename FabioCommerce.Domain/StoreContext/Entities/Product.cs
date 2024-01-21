namespace FabioCommerce.Domain.StoreContext.Entities
{
    public class Product
    {

        public Product(int id, string title, string description, string image, decimal price, int stock)
        {
            Id = id;
            Title = title;
            Description = description;
            Image = image;
            Price = price;
            Stock = stock;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
