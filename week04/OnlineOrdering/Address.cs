using System;

//Represents a physical address
public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public string Street
    {
        get { return _street; }
        set { _street = value; }
    }

    public string City
    {
        get { return _city; }
        set { _city = value; }
    }

    public string State
    {
        get { return _state; }
        set { _state = value; }
    }

    public string Country
    {
        get { return _country; }
        set { _country = value; }
    }


    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool CountryStatus()
    {
        if (_country.ToLower() == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

   

    public DisplayAddress()
    {
        return $"{_street}, {_city}, {_state}  {_country}";
    }

}
