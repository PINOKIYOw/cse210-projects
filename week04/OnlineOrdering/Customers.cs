using System;
using System.Reflection.Metadata.Ecma335;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsUSA()
    {
        return _address.IsUSA();
    }

    public string GetDisplayText()
    {
        return $"Name: {_name} {_address.GetDisplayAddress()}";
    }
}