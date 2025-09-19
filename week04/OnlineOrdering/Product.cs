//Represents a product available for purchase
public class Product
{
    public string ProductId;
    public string Name;
    public decimal Price;
    public string Description;

    public Product(string productId, string name, decimal price, string description)
    {
        ProductId = productId;
        Name = name;
        Price = price;
        Description = description;
    }

    public override string ToString()
    {
        return $"ID: {ProductId}, Name:{Name}, Price: {Price:C}";
    }
}