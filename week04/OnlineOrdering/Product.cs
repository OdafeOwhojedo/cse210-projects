using System;

//Represents a product available for purchase
public class Product
{
    private string _productId;
    private string _productName;
    private decimal _productPrice;
    private int _productQuantity;

    public string ProductID
    {
        get { return _productId; }
        set { _productId = value; }
    }

    public string ProductName
    {
        get { return _productName; }
        set { _productName = value; }
    }

    public decimal ProductPrice
    {
        get { return _productPrice; }
        set { _productPrice = value; }
    }

    public int ProductQuantity
    {
        get { return _productQuantity; }
        set { _productQuantity = value; }
    }

    public Product(string productId, string productName, decimal productPrice, int productQuantity)
    {
        _productId = productId;
        _productName = productName;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    public decimal CalculateCost()
    {
       
        decimal totalCost = _productPrice * _productQuantity;
        return totalCost;
    }

    
}