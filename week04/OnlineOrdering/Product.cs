using System;
using System.Numerics;

public class Product
{
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;

    public Product(string name, int productID, double price, int _quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int productID
    {
        get { return _productID; }
        set { _productID = value; }
    }

    public double Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }

    public double Subtotal()
    {
        return _price * _quantity;
    }

    public string GetSubtotalInfo()
    {
        return $"{_name} (x{_quantity}): $ {Subtotal():0.00}";
    }

    public string GetPackingInfo()
    {
        return $"{_name}, {_productID}, $ {_price:0.00} x {_quantity}";
    }
}