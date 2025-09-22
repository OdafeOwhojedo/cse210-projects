using System;
using System.Collections.Generic;
//Represents a customer placing an order
public class Customer
{
    private string _firstName;
    private string _lastName;
    private Address _shippingAddress;
    
    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public Customer(string firstName, string lastName, Address shippingAddress)
    {
        _firstName = firstName;
        _lastName = lastName;
        _shippingAddress = shippingAddress;
        
    }

    public bool AddressCountry()
    {
        bool countryUSA;
        countryUSA = _shippingAddress.CountryStatus();
        return countryUSA;
    }
    public string DisplayCustomerAddress()
    {
        string shippingInfo = _shippingAddress.DisplayAddress();
        return shippingInfo;
        
    }
   
}