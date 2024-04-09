using System;

public class Order
{
 Customer _customer;
 private List<Product> _products=new List<Product>();

 public Order(Customer customer)
 {
    _customer=customer;
 }
 private double Total()
 {
    double sum=0;
    foreach (Product product in _products)
    {
        sum+=product._price;
    }

    bool shipping=_customer.Shipping();
    if (shipping==true)
    {
        sum+=5;
        return sum;
    }
    else
    {
        sum+=35;
        return sum;
    }
 }

 private void DisplayLabel()
 {
    foreach (Product product in _products)
    {
        product.DisplayLabel();
    }
 }
 public void AddProduct(Product product)
 {
   _products.Add(product);
 }

 private void ShippingLabel()
 {
    _customer.DisplayCustomerLabel();
    
 }
 public void Labels()
 {
    ShippingLabel();
    ShippingLabel();
 }
}