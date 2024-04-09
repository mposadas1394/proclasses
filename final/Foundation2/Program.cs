using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Please, complete the following personal information:");
        Console.WriteLine("Name: ");
        string name=Console.ReadLine();
        Console.WriteLine("Street Address:");
        string street=Console.ReadLine();
        Console.WriteLine("City: ");
        string city=Console.ReadLine();
        Console.WriteLine("State/Province");
        string state=Console.ReadLine();
        Console.WriteLine("Country: ");
        string country=Console.ReadLine();

        Adress adress=new Adress(street,city,state,country);
        Customer customer=new Customer(name, adress);
        Order order=new Order(customer);
        
        string answer="";
        do
        {
            Console.WriteLine("want to add a product to the order?");
            answer=Console.ReadLine();
            Console.WriteLine("Complete the following information:");
            Console.WriteLine("Name: ");
            string product=Console.ReadLine();
            Console.WriteLine("Id: ");
            int id=int.Parse(Console.ReadLine());
            Console.WriteLine("Price");
            double price=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantity: ");
            int quantity=int.Parse(Console.ReadLine());
            Product product1=new Product(product,id, price, quantity);
            order.AddProduct(product1);
                      
        } while (answer!="no");
        Console.WriteLine("This is your order: ");
        order.Labels();
    }
}