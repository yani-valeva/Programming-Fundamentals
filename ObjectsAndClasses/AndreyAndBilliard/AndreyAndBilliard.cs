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
        SortedDictionary<string, Dictionary<string, decimal>> customers = new SortedDictionary<string, Dictionary<string, decimal>>();

        while (!currentClient.Equals("end of clients"))
        {
            string[] clientInfo = currentClient.Split('-');
            string[] orderedProductAndQuantity = clientInfo[1].Split(',');
            string product = orderedProductAndQuantity[0];
            decimal quantity = decimal.Parse(orderedProductAndQuantity[1]);
            Customer customer = new Customer();
            customer.ShopList = new Dictionary<string, decimal>();
            customer.Name = clientInfo[0];
            customer.ShopList.Add(product, quantity);

            if (productsInShop.ContainsKey(product))
            {
                if (!customers.ContainsKey(customer.Name))
                {
                    customers.Add(customer.Name, new Dictionary<string, decimal>());
                }
                if (!customers[customer.Name].ContainsKey(product))
                {
                    customers[customer.Name][product] = 0;
                }

                customers[customer.Name][product] += quantity;
            }
                       
            currentClient = Console.ReadLine();
        }

        decimal totalBill = 0m;

        foreach (var customer in customers)
        {
            string currentCustomerName = customer.Key;
            var selectedProductsAndQuantity = customer.Value.ToDictionary(x => x.Key, x => x.Value);
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
