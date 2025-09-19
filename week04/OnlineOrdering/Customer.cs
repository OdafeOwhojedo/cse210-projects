using System;
using System.Collections.Generic;
//Represents a customer placing an order
public class Customer
{
    public string CustomerId;
    public string FirstName;
    public string LastName;
    public string Email;
    public Address ShippingAddress;
    public List<Order> Orders;

    public Customer(string customerId, string firstName, string lastName, string email, Address shippingAddress)
    {
        CustomerId = customerId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        ShippingAddress = shippingAddress;
        Orders = new List<Order>();
    }

    public void AddOrder(Order order)
    {
        Orders.Add(order);
    }

    public override string ToString()
    {
        return $"Customer ID: {CustomerId}, Name: {FirstName} {LastName}, Email: {Email}";

    }
}