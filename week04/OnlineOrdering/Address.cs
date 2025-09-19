using System;
using System.Collections.Generic;
using System.Linq;
//Represents a physical address
public class Address
{
    public string Street;
    public string City;
    public string State;
    public string ZipCode;
    public string Country;

    public Address(string street, string city, string state, string zipCode, string country)
    {
        Street = street;
        City = city;
        State = state;
        ZipCode = zipCode;
        Country = country;
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {State} {ZipCode} {Country}";
    }

}
