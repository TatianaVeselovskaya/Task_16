using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;


namespace Task_16_max_strong
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../../Products.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

            Product maxProduct = products[0];
            foreach (Product e in products)
            {
                if (e.Price > maxProduct.Price)
                {
                    maxProduct = e;
                }
            }
            Console.WriteLine($"{maxProduct.Num} {maxProduct.Name} {maxProduct.Price}");
            Console.ReadKey();
        }
    }
}