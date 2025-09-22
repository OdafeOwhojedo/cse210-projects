using System;
using System.Collections.Generic;
using System.Linq;
//Represents a customer's order
public class Order
{
    private Customer _customer;
    private List<Product> _products;
    private decimal _shippingCost;
    private decimal _grandTotalAmount;

    public Order( Customer customer, Product product)
    {
        _customer = customer;
        _products = new List<Product>();

    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
        
    }


    public void CalculateTotalAmount()
    {
        bool costOfShipping = _customer.AddressCountry();
        if (costOfShipping == true)
        {
            _shippingCost = 5;
            _grandTotalAmount = _products.Sum(product => product.CalculateCost() ) + _shippingCost;
            
           
        }
        else
        {
            _shippingCost = 35;
            _grandTotalAmount = _products.Sum(product => product.CalculateCost()) + _shippingCost;
            
        }
            
    }

    public  void DisplayPackingLabel()
    {
        Console.WriteLine("------------Packing Label Information------------");
        foreach (var item in _products)
        {
            Console.WriteLine($"Name of Product: {item.ProductName}\n Product ID: {item.ProductID} ");

        }
        
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("-------------Shipping Label-------------");
        Console.WriteLine($"Name of Customer: {_customer.FirstName}  {_customer.LastName} \nAddress of Customer: {_customer.DisplayCustomerAddress()}");
        Console.WriteLine($"Total Cost: {_grandTotalAmount}");
    }

}