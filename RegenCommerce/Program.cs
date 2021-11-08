using RegenCommerce.Model;
using System;

namespace RegenCommerce
{
    public static class MyProgram
    {
        public static void Main(string[] args)
        {
            string greeting = "Hello ";
           
            var customer = new Customer 
            {
                FirstName = "Ioannis",
                LastName = "Eleftheriou",
                Balance = 10,
                BirthDate = new DateTime(1970, 12, 5)
            };


            var cust2 = customer;

           


            var cust3 = new Customer
            {
                FirstName = customer.FirstName,
                LastName =  customer.LastName,
                Balance = 0,
                BirthDate = new DateTime(1980, 12, 5)
            };
                customer.FirstName = "Eirini";

            Console.WriteLine(greeting + cust3.FirstName);

        }
    }
}
