using System.Reflection.Metadata.Ecma335;
using System.Security.Authentication;

public class Address
{
    //The address contains a string for the street address, the city, state/province, and country.
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    //The address should have a method that can return whether it is in the USA or not.
    public bool LivesInAmerica()
    {
        if (_country == "USA")
        {
            return true;
        }
        
        else 
        {
            return false;
        }
    }

    //The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)
    public string DisplayAddress()
    {
        return $"Address: {_streetAddress} \n         {_city}, {_state} {_country}";
    }
}