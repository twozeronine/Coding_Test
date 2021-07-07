using System;
using System.Linq;
using System.Collections.Generic;

namespace Aggregators
{
  public class Count
  {
    //  Distinct 메서드로 중복되는 값 제거후 숫자 세기
    public static void DistinctCount()
    {
      int[] factorsOf300 = { 2, 2, 3, 5, 5 };

      int uniqueFactors = factorsOf300.Distinct().Count();

      Console.WriteLine($"uniqueFactors = {uniqueFactors} ");

      /* 출력
      uniqueFactors = 3
      */
    }

    public static void GetOddNumbersCount()
    {
      int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

      // Count 메서드에 조건을 람다 함수로 제공하여 조건에 맞는 요소를 셀수도 있다.
      int oddNumbers = numbers.Count(n => n % 2 == 1);


      Console.WriteLine($"oddNumbers = {oddNumbers} ");

      /* 출력
      oddNumbers = 5
      */
    }

    public class Customer
    {
      public int CustomerID;
      public string[] Orders;
    }


    // 쿼리 문 내에서 그룹 개수 세기
    public static void CountOrder()
    {
      List<Customer> customers = new List<Customer>()
      {
        new Customer(){CustomerID= 1, Orders = new string[]{"상자","휴대폰","접시"}},
        new Customer(){CustomerID= 2, Orders = new string[]{"접시"}},
        new Customer(){CustomerID= 3, Orders = new string[]{"스피커","휴대폰"}},
        new Customer(){CustomerID= 4, Orders = new string[]{"휴대폰","헤드셋","메모장"}},
        new Customer(){CustomerID= 5, Orders = new string[]{"외장하드","안경"}},
        new Customer(){CustomerID= 6, Orders = new string[]{"키보드","USB","접시"}},
      };

      var orderCounts = from c in customers
                        select (c.CustomerID, OrderCount: c.Orders.Count());

      Console.Write($"orderCounts = [ ");
      foreach (var order in orderCounts)
      {
        Console.WriteLine($" {order.CustomerID}님의 주문 갯수 : {order.OrderCount} ");
      }
      Console.WriteLine(" ] ");

      /* 출력
      orderCounts = [  
                      1님의 주문 갯수 : 3
                      2님의 주문 갯수 : 1
                      3님의 주문 갯수 : 2
                      4님의 주문 갯수 : 3
                      5님의 주문 갯수 : 2
                      6님의 주문 갯수 : 3
                    ]
      */

    }
  }
}
