using System;
public class Adress
{
     private string _street;
    private string _city;
    
    private string _stateOrProvince;
    private string _country;

    public Adress(string street, string city,string stateOrProvince,string country)
{
    _street = street;
    _city = city;
    _stateOrProvince = stateOrProvince;
    _country = country;
}

public void DisplayAddress()
{
    Console.WriteLine($"street: {_street}, city: {_city}, state/province: {_stateOrProvince}, country:{_country}");
}
}