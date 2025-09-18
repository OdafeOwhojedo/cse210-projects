//Represents a product available for purchase
public class Product
{
    private int _productID;
    private string _name;
    private float _price;

    public Product(int productID, string name, float price)
    {
        _productID = productID;
        _name = name;
        _price = price;
    }

    public override string ToString()
    {
        return $"ID:  {_productID}, Name: {_name}, Price: {_price:C}";
    }
}