using System;
using System.Collections.Generic;
using System.Linq;

public class AndreyAndBilliard
{
    public static void Main()
    {
        Dictionary<string, decimal> productsInShop = new Dictionary<string, decimal>();

        int amountOfEntities = int.Parse(Console.ReadLine());

        for (int i = 0; i < amountOfEntities; i++)
        {
            string[] input = Console.ReadLine().Split('-');
            string productName = input[0];
            decimal productPrice = decimal.Parse(input[1]);

            if (!productsInShop.ContainsKey(productName))
            {
                productsInShop.Add(productName, 0m);
            }

            productsInShop[productName] = productPrice;
        }

        string currentClient = Console.ReadLine();
        List<Customer> customers = new List<Customer>();

        while (!currentClient.Equals("end of clients"))
        {
            string[] clientInfo = currentClient.Split('-');
            string[] orderedProductAndQuantity = clientInfo[1].Split(',');
            string product = orderedProductAndQuantity[0];
            decimal quantity = decimal.Parse(orderedProductAndQuantity[1]);            
            string customerName = clientInfo[0];            
            
            if (productsInShop.ContainsKey(product))
            {
                if (!customers.Any(c => c.Name == customerName))
                {
                    Customer customer = new Customer();
                    customer.Name = customerName;
                    customer.ShopList = new Dictionary<string, decimal>();
                    customer.ShopList.Add(product, quantity);
                    customers.Add(customer);
                }
                else
                {
                    Customer customer = customers.First(c => c.Name == customerName);
                    if (!customer.ShopList.ContainsKey(product))
                    {
                        customer.ShopList.Add(product, 0);
                    }

                    customer.ShopList[product] += quantity;
                }
            }

            currentClient = Console.ReadLine();
        }
        
        decimal totalBill = 0m;

        foreach (var customer in customers.OrderBy(n => n.Name))
        {
            string currentCustomerName = customer.Name;
            var selectedProductsAndQuantity = customer.ShopList.ToDictionary(x => x.Key, x => x.Value);
            decimal bill = 0m;

            Console.WriteLine(currentCustomerName);

            foreach (var product in selectedProductsAndQuantity)
            {
                string currentProduct = product.Key;
                decimal currentQuantity = product.Value;
                decimal currentPrice = productsInShop[currentProduct];

                Console.WriteLine($"-- {currentProduct} - {currentQuantity}");

                bill += currentQuantity * currentPrice;
            }

            totalBill += bill;

            Console.WriteLine($"Bill: {bill:f2}");
        }

        Console.WriteLine($"Total bill: {totalBill:f2}");
    }
}