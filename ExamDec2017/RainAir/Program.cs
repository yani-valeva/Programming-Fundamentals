using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<int>> customers = new Dictionary<string, List<int>>();
        string input = Console.ReadLine();
        while (!input.Equals("I believe I can fly!"))
        {
            string[] customerInfo = input.Split();
            string name = customerInfo[0];

            if (customerInfo[1] == "=")
            {
                string secondCustomer = customerInfo[2];

                if (customers.ContainsKey(name) && customers.ContainsKey(secondCustomer))
                {
                    customers[name].Clear();
                    List<int> newFlights = new List<int>();
                    newFlights = customers[secondCustomer];
                    for (int i = 0; i < newFlights.Count; i++)
                    {
                        customers[name].Add(newFlights[i]);
                    }
                }
            }
            else
            {
                if (!customers.ContainsKey(name))
                {
                    customers.Add(name, new List<int>());
                }

                for (int i = 1; i < customerInfo.Length; i++)
                {
                    customers[name].Add(int.Parse(customerInfo[i]));
                }
                
            }

            input = Console.ReadLine();
        }

        foreach (var customer in customers.OrderByDescending(c => c.Value.Count).ThenBy(c => c.Key))
        {
            List<int> flights = new List<int>();
            flights = customers[customer.Key];
            flights.Sort();

            Console.WriteLine($"#{customer.Key} ::: {String.Join(", ", flights)}");
        }
    }
}