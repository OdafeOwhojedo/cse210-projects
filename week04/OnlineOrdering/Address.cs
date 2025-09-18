using System;
using System.Collections.Generic;
using System.Linq;
//Represents a physical address
public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _postalCode;
    private string _country;

    public Address(string street, string city, string state, string postalCode, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _postalCode = postalCode;
        _country = country;
    }

    public override string ToString()
    {
        return $"{_street}, {_city}, {_state}, {_postalCode}, {_country}";
    }
}
