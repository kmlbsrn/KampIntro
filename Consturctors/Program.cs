using System;

namespace Consturctors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1,FirstName="kemal",LastName="basaran",City="ankmara" };
            Customer customer2 = new Customer(3, "Deniz", "su", "ankara");
            Console.WriteLine(customer2.LastName);
        }


        
    
    }
    class Customer
    {
        public Customer()
        {
                
        }
        public Customer(int id,string firstName,string lastName,string city)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
                
        }
        public int Id { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public string City { get; set; }
    }
    
}
 