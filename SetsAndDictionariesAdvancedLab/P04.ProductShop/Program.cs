using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string,Dictionary<string,double>> stores=new SortedDictionary<string,Dictionary<string,double>>();
            string cmd;
            while ((cmd=Console.ReadLine())!="Revision")
            {
                string[] tokens=cmd.Split(", ");
                string storeName=tokens[0];
                string currProduct=tokens[1];
                double currProductPrice = double.Parse(tokens[2]);
                if (!stores.ContainsKey(storeName))
                    stores[storeName] = new Dictionary<string, double>();
                stores[storeName].Add(currProduct, currProductPrice);
            }
            //"{shop}-> 
            // Product: {product}, Price: {price}"
            stores.OrderBy(kvp => kvp.Key);
            foreach (var store in stores)
            {
                Console.WriteLine($"{store.Key}->");
                foreach (var kvp in store.Value)
                    Console.WriteLine($"Product: {kvp.Key}, Price: {kvp.Value}");
                    
                
            }
        }
    }
}
