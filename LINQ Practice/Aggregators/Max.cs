using System;
using System.Linq;
using System.Collections.Generic;

namespace Aggregators
{
  public class Max
  {
    // 집합 내 최댓값 찾기 
    public static void GetMax()
    {
      int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

      double maxNum = numbers.Max();

      Console.WriteLine($"maxNum = {maxNum} ");

      /* 출력
      maxNum = 9 
      */
    }

    // 집합 내 원소를 사용하여 최댓값 찾기
    public static void GetLongestLength()
    {
      string[] words = { "cherry", "apple", "blueberry" };

      int longestLegnth = words.Max(w => w.Length);

      Console.WriteLine($"longestLegnth = {longestLegnth} ");


      /* 출력
      longestLegnth = 9 
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
                       select (Category: g.Key, MostExpensivePrice: g.Max(p => p.UnitPrice));

      var categories2 = from p in products
                        group p by p.Category into g
                        let maxPrice = g.Min(p => p.UnitPrice)
                        select (Category: g.Key, MostExpensivePrice: g.Where(p => p.UnitPrice == maxPrice));


      foreach (var product in categories)
      {
        Console.Write($"{product.Category} : [ {product.MostExpensivePrice}");
        Console.WriteLine(" ] ");
      }
      Console.WriteLine();

      foreach (var product in categories2)
      {
        Console.WriteLine($" {product.Category} ");
      }
      Console.WriteLine();

      /*  실행결과
          book : [ 10 ] 
          fruit : [ 12 ]

          book
          fruit

      */

    }
  }
}