using System;
using System.Linq;
using System.Collections.Generic;




public class Where
{
  public static void FindLowNums()
  {
    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

    var lowNums = from num in numbers
                  where num < 5
                  select num;

    Console.Write($"lowNums = [ ");
    foreach (var number in lowNums)
    {
      Console.Write($" {number} ");
    }
    Console.WriteLine(" ] ");
  }
  public class Product
  {
    public string UnitName;
    public int UnitsInStock;
    public int UnitPrice;
  }
  public static void FilterProducts()
  {
    List<Product> products = new List<Product>()
    {
        new Product(){UnitName="상자", UnitsInStock=1, UnitPrice = 100},
        new Product(){UnitName="휴대폰", UnitsInStock=2, UnitPrice = 200},
        new Product(){UnitName="장갑", UnitsInStock=0, UnitPrice = 150},
        new Product(){UnitName="모자", UnitsInStock=5, UnitPrice = 350},
        new Product(){UnitName="옷", UnitsInStock=2, UnitPrice = 400},
        new Product(){UnitName="가방", UnitsInStock=0, UnitPrice = 500},
        new Product(){UnitName="색연필", UnitsInStock=0, UnitPrice = 600},
        new Product(){UnitName="컴퓨터", UnitsInStock=1, UnitPrice = 700},
    };

    var soldOutProducts = from prod in products
                          where prod.UnitsInStock == 0
                          select prod;

    var expensiveInStockProducts = from prod in products
                                   where prod.UnitsInStock > 0 && prod.UnitPrice > 300
                                   select prod;

    Console.Write($"soldOutProducts = [ ");
    foreach (var product in soldOutProducts)
    {
      Console.Write($" {product.UnitName} ");
    }
    Console.WriteLine(" ] ");

    Console.Write($"expensiveInStockProducts = [ ");
    foreach (var product in expensiveInStockProducts)
    {
      Console.Write($" {product.UnitName} ");
    }
    Console.WriteLine(" ] ");
  }

  public class Customer
  {
    public Customer(string name, string region)
    {
      Name = name;
      Region = region;
    }

    public string Name;
    public string Region;
  }
  public static void FilterCustomerRegionList()
  {
    List<Customer> customers = new List<Customer>()
    {
      new Customer("John","LA"),
      new Customer("David","WA"),
      new Customer("Kong","NY"),
      new Customer("Kim","DD"),
      new Customer("Lee","WA"),
      };

    var waCustomers = from cust in customers
                      where cust.Region == "WA"
                      select cust;


    Console.Write($"waCustomers = [ ");
    foreach (var customer in waCustomers)
    {
      Console.Write($" {customer.Name} ");
    }
    Console.WriteLine(" ] ");
  }

  public static void FilterToIndex()
  {
    string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "nine", "ten" };

    var shortDigits = digits.Where((digits, index) => digits.Length < index);

    Console.Write($"shortDigits = [ ");
    foreach (var digit in shortDigits)
    {
      Console.Write($" {digit} ");
    }
    Console.WriteLine(" ] ");
  }
}
