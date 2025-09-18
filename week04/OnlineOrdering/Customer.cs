//Represents a customer placing an order
public class Customer
{
    private int _customerID;
    private string _firstName;
    private string _lastName;
    private Address _shippingAddress;

    public Customer(int customerID, string firstName, string lastName, Address shippingAddress)
    {
        _customerID = customerID;
        _firstName = firstName;
        _lastName = lastName;
        _shippingAddress = shippingAddress;
    }

    public override string ToString()
    {
        return $"Customer ID: {_customerID}, Name: {_firstName} {_lastName}, Shipping Address: {_shippingAddress}";
    }
}