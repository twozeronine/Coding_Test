using System;
using System.Linq;
using System.Collections.Generic;

namespace Aggregators
{
    public class Min
    {
        // 집합내 최솟값 찾기 
        public static void GetMin()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            double minNum = numbers.Min();

            Console.WriteLine($"minNum = {minNum} ");

            /* 출력
            minNum = 0 
            */
        }

        public static void GetShortestWord()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            int shortestWord = words.Min(w => w.Length);

            Console.WriteLine($"shortestWord = {shortestWord} ");

            /* 출력
            shortestWord = 5 
            */
        }

        public class Product
        {
            public Product(string category, int price)
            {
                Category = category;
                UnitPrice = price;
            }
            public string Category;
            public int UnitPrice;
        }
        public static void GetSameCategory()
        {
            List<Product> products = new List<Product>()
                 {
                    new Product("book",5),
                    new Product("fruit",3),
                    new Product("fruit",2),
                    new Product("book",1),
                    new Product("fruit",5),
                    new Product("book",4),
                    new Product("book",8),
                    new Product("fruit",12),
                    new Product("book",10),
                };

            var categories = from p in products
                             group p by p.Category into g
                             select (Category: g.Key, CheapestPrice: g.Min(p => p.UnitPrice));

            var categories2 = from p in products
                              group p by p.Category into g
                              let minPrice = g.Min(p => p.UnitPrice)
                              select (Category: g.Key, CheapestProducts: g.Where(p => p.UnitPrice == minPrice));


            foreach (var product in categories)
            {
                Console.Write($"{product.Category} : [ {product.CheapestPrice}");
                Console.WriteLine(" ] ");
            }
            Console.WriteLine();

            foreach (var product in categories2)
            {
                Console.WriteLine($" {product.Category} ");
            }
            Console.WriteLine();

            /*  실행결과
                book : [ 1 ] 
                fruit : [ 2 ] 

                book 
                fruit 

            */

        }
    }
}
