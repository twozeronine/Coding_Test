using System;
using System.Linq;
using System.Collections.Generic;

namespace Aggregators
{
  public class Average
  {
    // 집합 내 최댓값 찾기 
    public static void GetAverage()
    {
      int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

      double averageNum = numbers.Average();

      Console.WriteLine($"averageNum = {averageNum} ");

      /* 출력
      averageNum = 4.5 
      */
    }

    public static void GetAverageLegth()
    {
      string[] words = { "cherry", "apple", "blueberry" };

      double averageLegnth = words.Average(w => w.Length);

      Console.WriteLine($"averageLegnth = {averageLegnth} ");


      /* 출력
      averageLegnth = 6.666666666666667 
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
    public static void GetProductAveragePrice()
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
                       select (Category: g.Key, AveragePrice: g.Average(p => p.UnitPrice));

      foreach (var product in categories)
      {
        Console.Write($"{product.Category} : [ {product.AveragePrice}");
        Console.WriteLine(" ] ");
      }
      Console.WriteLine();
    }

    /* 출력
    book : [ 5.6 ]
    fruit : [ 5.5 ]
    */
  }
}
