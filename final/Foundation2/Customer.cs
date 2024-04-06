using System.Security.AccessControl;

//The customer contains a name and an address.
public class Customer
{
    //The name is a string, but the Address is a class.
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    //The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)
    public bool LivesInAmerica()
    {
        return _address.LivesInAmerica();
    }

    public string GetCustomerName() 
    {
        return _customerName;
    }

    public Address GetAddress()
    {
        return _address;
    }
}