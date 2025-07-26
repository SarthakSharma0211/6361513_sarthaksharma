using System;
using System.Collections.Generic;

class Program
{
    static Product LinearSearch(Product[] products, string name)
    {
        foreach (Product product in products)
        {
            if (product.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase))
                return product;
        }
        return null;
    }

    static Product BinarySearch(Product[] products, string name)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            int comparison = string.Compare(products[mid].ProductName, name, StringComparison.OrdinalIgnoreCase);
            if (comparison == 0)
                return products[mid];
            else if (comparison < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }

    static void Main()
    {
        Product[] products = new Product[]
        {
            new Product(101, "Laptop", "Electronics"),
            new Product(102, "Shoes", "Fashion"),
            new Product(103, "Watch", "Accessories"),
            new Product(104, "Mobile", "Electronics"),
            new Product(105, "Book", "Education")
        };

        Console.WriteLine("🔍 Linear Search for 'Watch':");
        var result1 = LinearSearch(products, "Watch");
        Console.WriteLine(result1 != null ? $"Found: {result1.ProductName}" : "Not Found");

        Array.Sort(products, (p1, p2) => p1.ProductName.CompareTo(p2.ProductName));

        Console.WriteLine("\n🔍 Binary Search for 'Watch':");
        var result2 = BinarySearch(products, "Watch");
        Console.WriteLine(result2 != null ? $"Found: {result2.ProductName}" : "Not Found");
    }
}