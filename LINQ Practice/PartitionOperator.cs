using System;
using System.Linq;
using System.Collections.Generic;




public class PartitionOperator
{
  // Take 분할 연산자
  // Take 메서드로 numbers 배열에서 처음 3개의 원소만 꺼내 출력 시퀀스를 만듭니다.
  // 출력 시퀀스는 IEnumerable 인터페이스로 반환되므로, LINQ 결과에 Take 메서드를 연결하여 사용할 수 있습니다.
  public static void TakeNumber()
  {
    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

    var first3Numbers = numbers.Take(3);

    Console.Write($"first3Numbers = [ ");
    foreach (var number in first3Numbers)
    {
      Console.Write($" {number} ");
    }
    Console.WriteLine(" ] ");

    /*출력
    first3Numbers = [  5  4  1  ] 
    */
  }

  public class Orders
  {
    public int OrderID;
    public string OrderDate;
  }
  public class Customer
  {
    public Customer(string name, string region, Orders[] orders)
    {
      Name = name;
      Region = region;
      Orders = orders;
    }

    public string Name;
    public string Region;
    public Orders[] Orders;
  }

  public static void Take3OrdersFromSamePlace()
  {
    Orders[] orders = new Orders[]{new Orders(){OrderID=1,OrderDate="화요일"},
                                   new Orders(){OrderID=2,OrderDate="월요일"},
                                   new Orders(){OrderID=3,OrderDate="수요일"},
                                   new Orders(){OrderID=4,OrderDate="월요일"},
                                   new Orders(){OrderID=5,OrderDate="목요일"},
                                   };
    List<Customer> customers = new List<Customer>()
    {
      new Customer("John","LA",orders),
      new Customer("David","WA",orders),
      new Customer("Kim","DO",orders),
      new Customer("Lee","WA",orders),
      new Customer("Jang","NY",orders),
      };

    var first3WAOrders = (
      from cust in customers
      from order in cust.Orders
      where cust.Region == "WA"
      select (cust.Name, order.OrderID, order.OrderDate))
      .Take(3);

    Console.Write($"first3WAOrders = [ ");
    foreach (var order in first3WAOrders)
    {
      Console.Write($" {order.Name} {order.OrderID} {order.OrderDate} ");
    }
    Console.WriteLine(" ] ");

    /*출력 
    first3WAOrders = [  David 1 화요일  David 2 월요일  David 3 수요일  ]
    */
  }

  // Skip 분할 연산자
  // Skip 메서드로 numbers 배열에서 처음 4개의 원소를 건더뛰고 출력 시퀀스를 만듭니다.
  // Take 메서드와 마찬가지로, Skip 메서드도 IEnumerable 인터페이스에 정의되어 있어서 LINQ 결과에 연결하여 사용할 수 있습니다.
  public static void Skip4Numbers()
  {
    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

    var allButFirst4Numbers = numbers.Skip(4);


    Console.Write($"allButFirst4Numbers = [ ");
    foreach (var number in allButFirst4Numbers)
    {
      Console.Write($" {number} ");
    }
    Console.WriteLine(" ] ");

    /*출력결과
    allButFirst4Numbers = [  9  8  6  7  2  0  ]
    */
  }

  public static void GetUntil2Orders()
  {
    Orders[] orders = new Orders[]{new Orders(){OrderID=1,OrderDate="화요일"},
                                   new Orders(){OrderID=2,OrderDate="월요일"},
                                   new Orders(){OrderID=3,OrderDate="수요일"},
                                   new Orders(){OrderID=4,OrderDate="월요일"},
                                   new Orders(){OrderID=5,OrderDate="목요일"},
                                   };
    List<Customer> customers = new List<Customer>()
    {
      new Customer("John","LA",orders),
      new Customer("David","WA",orders),
      new Customer("Kim","DO",orders),
      new Customer("Lee","WA",orders),
      new Customer("Jang","NY",orders),
      };

    var waOrders = from cust in customers
                   from order in cust.Orders
                   where cust.Region == "WA"
                   select (cust.Name, order.OrderID, order.OrderDate);

    var allButFirst2Orders = waOrders.Skip(2);

    Console.Write($"allButFirst2Orders = [ ");
    foreach (var order in allButFirst2Orders)
    {
      Console.Write($" {order.Name} {order.OrderID} {order.OrderDate} ");
    }
    Console.WriteLine(" ] ");

    /*출력결과
    allButFirst2Orders = [  David 3 수요일  David 4 월요일  David 5 목요일  Lee 1 화요일  Lee 2 월요일  Lee 3 수요일  Lee 4 월요일  Lee 5 목 
요일  ]
    */
  }

  // TakeWhile 분할 연산자
  // TakeWhile 와 SkilWhile 은 Take와 Skip과 달리, 주어진 조건에 도달하기 전까지만 출력 시퀀스에 포함합니다.
  // TakeWhile 메서드로 numbers 배열 원소 중 6 보다 작은 원소가 나오기 전만 출력 시퀀스에 포합합니다.

  public static void TakeFirstNumbersLessThan6()
  {
    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

    var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);

    Console.Write($"firstNumbersLessThan6 = [ ");
    foreach (var number in firstNumbersLessThan6)
    {
      Console.Write($" {number} ");
    }
    Console.WriteLine(" ] ");

    /*출력결과
    firstNumbersLessThan6 = [  5  4  1  3  ]
    */
  }

  public static void TakeFirstSmallNumbers()
  {
    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

    var firstSmallNumbers = numbers.TakeWhile((n, idx) => n >= idx);

    Console.Write($"firstSmallNumbers = [ ");
    foreach (var number in firstSmallNumbers)
    {
      Console.Write($" {number} ");
    }
    Console.WriteLine(" ] ");

    /* 출력 
    firstSmallNumbers = [  5  4  ]
    */
  }

  // SkipWhile 분할 연산자
  // numbers 배열 첫 원소부터 시작해서 3으로 나누어 떨어지지 않는 원소를 건너뛰고, 3으로 나누어 떨어지는 원소부터 출력 시퀀스를 만듭니다.

  public static void SkipWhile()
  {
    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

    var allButFirst3Numbers = numbers.SkipWhile(n => n % 3 != 0);

    Console.Write($"allButFirst3Numbers = [ ");
    foreach (var number in allButFirst3Numbers)
    {
      Console.Write($" {number} ");
    }
    Console.WriteLine(" ] ");

    /* 출력 
    allButFirst3Numbers = [  3  9  8  6  7  2  0  ]
    */

  }
}