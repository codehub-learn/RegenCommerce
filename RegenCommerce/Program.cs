using RegenCommerce.Model;
using System;
using System.Collections.Generic;

namespace RegenCommerce
{
    public static class MyProgram
    {
        public static void Main(string[] args)
        {

            DoWork();

        }

        private static void DoWork()
        {
            string userName;
            Console.WriteLine("Give your name ");
            userName = Console.ReadLine();

            Console.WriteLine("hello " + userName);


            string greeting = "Hello ";

            var customer = new Customer
            {
                FirstName = "Ioannis",
                LastName = "Eleftheriou",
                Balance = 10,
                BirthDate = new DateTime(1970, 12, 5)
            };


            var cust2 = customer;
            if (cust2.Balance > 100)
                Console.WriteLine($"cust {cust2.LastName} owns {cust2.Balance}");
            else
                Console.WriteLine("cust " + cust2.LastName + "owns below 100 Euros");


            var cust3 = new Customer
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Balance = 0,
                BirthDate = new DateTime(1980, 12, 5)
            };
            customer.FirstName = "Eirini";

            Console.WriteLine(greeting + cust3.FirstName);
        }
    }
}
