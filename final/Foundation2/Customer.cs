using System;

public class Customer
{
    private string _name;
    Adress _adress;

public Customer(string name, Adress adress)
{
    _name = name;
    _adress = adress;
}
public bool Shipping()
{
    bool shipping=_adress.Shipping();
    return shipping;
}
public void DisplayCustomerLabel()
{
    _adress.DisplayShippingInformation();
}
}