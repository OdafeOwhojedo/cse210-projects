using System;
using System.Collections.Generic;
using System.Linq;
//Represents a customer's order
public class Order
{
    public string OrderId;
    public DateTime OrderDate;
    public Customer Customer;
    public List<Product> Products;
    public decimal TotalAmount;

    public Order(string orderId, Customer customer)
    {
       OrderId = orderId;
       OrderDate = DateTime.Now;
       Customer = customer;
       Products = new List<Product>();
       CalculateTotalAmount();//Initialize the total
    }

     public void AddProduct(Product product)
     {
        Products.Add(product);
        CalculateTotalAmount();
      }

    public void RemoveProduct(Product product)
    {
         Products.Remove(product);
         CalculateTotalAmount();
    }

     public void CalculateTotalAmount()
     {
         TotalAmount = Products.Sum(p => p.Price);
     }

     public override string ToString()
     {
         return $"Order ID: {OrderId}, Date: {OrderDate.ToShortDateString()}, Customer: {Customer.FirstName} {Customer.LastName}, Total: {TotalAmount:C}";
     }

}