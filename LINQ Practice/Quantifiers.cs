using System;
using System.Linq;
using System.Collections.Generic;

public class Quantifiers
{
  // 하나라도 조건에 맞는 요소가 있는지 확인하기
  public static void isElementHere()
  {
    string[] words = { "believe", "relief", "receipt", "field" };

    bool iAfterE = words.Any(w => w.Contains("ei"));

    Console.Write($"iAfterE = [ {iAfterE} ");
    Console.WriteLine(" ] ");

    // words 배열 안에 "receipt"는 "ei"를 포함하므로 iAfterE는 true가 된다.
    /* 출력
    iAfterE = [ True  ] 
    */
  }

  // 모든 요소가 조건에 맞는지 확인하기
  public static void isOnlyOdd()
  {
    int[] numbers = { 1, 11, 3, 19, 41, 65, 19 };

    bool onlyOdd = numbers.All(n => n % 2 == 1);

    Console.Write($"onlyOdd = [ {onlyOdd} ");
    Console.WriteLine(" ] ");

    // numbers 배열에 홀수인 숫자만 존재하므로 onlyOdd는 true가 된다.
    /* 출력
    onlyOdd = [ True  ] 
    */
  }

  // Group 별로 확인하기

  public class Product
  {
    public int key;
    public string Category;
    public int UnitsInStock;
  }

  public static void isGroupHaveStock()
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

    var productZeroStockGroups = from p in products
                                 group p by p.Category into g
                                 where g.Any(p => p.UnitsInStock == 0)
                                 select (Category: g.Key, Products: g);

    var productStockGroups = from p in products
                             group p by p.Category into g
                             where g.Any(p => p.UnitsInStock > 0)
                             select (Category: g.Key, Products: g);

    Console.Write($"productZeroStockGroups = [ ");
    foreach (var product in productZeroStockGroups)
    {
      Console.Write($" Category : {product.Category} , Products : ");
      foreach (var p in product.Products)
      {
        Console.Write($"{p.UnitsInStock} / ");
      }
      Console.WriteLine();
    }
    Console.WriteLine(" ] ");

    Console.Write($"productStockGroups = [ ");
    foreach (var product in productStockGroups)
    {
      Console.Write($" Category : {product.Category} , Products : ");
      foreach (var p in product.Products)
      {
        Console.Write($"{p.UnitsInStock} / ");
      }
      Console.WriteLine();
    }
    Console.WriteLine(" ] ");

    /* 출력
    productZeroStockGroups = [  
      Category : 네모 , Products : 0 / 3 / 5 / 4 / 
      Category : 세모 , Products : 0 / 2 / 0 / 
      Category : 동그라미 , Products : 0 / 0 / 0 / 
    ] 

    productStockGroups = [  
      Category : 네모 , Products : 0 / 3 / 5 / 4 / 
      Category : 세모 , Products : 0 / 2 / 0 / 
    ] 
    */

  }
}