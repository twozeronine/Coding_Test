using System;
using System.Linq;
using System.Collections.Generic;

namespace Aggregators
{
  public class Sum
  {
    //  Distinct 메서드로 중복되는 값 제거후 숫자 세기
    public static void SumNumbers()
    {
      int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

      double numSum = numbers.Sum();

      Console.WriteLine($"numSum = {numSum} ");

      /* 출력
      numSum = 45 
      */
    }

    public static void SumLength()
    {
      string[] words = { "cherry", "apple", "blueberry" };

      double totalChars = words.Sum(w => w.Length);

      Console.WriteLine($"totalChars = {totalChars} ");

      /* 출력
      totalChars = 20 
            */
    }
    public class Product
    {
      public int key;
      public string Category;
      public int UnitsInStock;
    }

    public static void SumInproduct()
    {
      List<Product> products = new List<Product>(){
      new Product(){Category="네모",UnitsInStock =0},
      new Product(){Category="네모",UnitsInStock =3},
      new Product(){Category="세모",UnitsInStock =0},
      new Product(){Category="동그라미",UnitsInStock =0},
      new Product(){Category="세모",UnitsInStock =2},
      new Product(){Category="동그라미",UnitsInStock =0},
      new Product(){Category="네모",UnitsInStock =5},
      new Product(){Category="네모",UnitsInStock =4},
      new Product(){Category="동그라미",UnitsInStock =0},
      new Product(){Category="세모",UnitsInStock =0},
      };

      var categories = from p in products
                       group p by p.Category into g
                       select (Category: g.Key, TotalUnitsInStock: g.Sum(p => p.UnitsInStock));


      Console.Write($"categories = [ ");
      foreach (var category in categories)
      {
        Console.WriteLine($" {category.Category} : {category.TotalUnitsInStock} ");
      }
      Console.WriteLine(" ] ");

      /* 출력
      categories = [  
                    네모 : 12
                    세모 : 2
                    동그라미 : 0
                  ]
      */
    }
  }
}
