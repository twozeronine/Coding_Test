using System;
using System.Linq;
using System.Collections.Generic;

namespace Aggregators
{
  public class Aggregate
  {
    // 집합 내 최댓값 찾기 
    public static void GetAggregate()
    {
      double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

      double product = doubles.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);

      Console.WriteLine($"product = {product} ");

      /* 출력
      product = 88.33080999999999 
      */
    }

    public static void GetfruitAggregate()
    {
      string[] fruits = { "apple", "mango", "orange", "passionfruit", "grape" };

      string line = fruits.Aggregate((line, fruit) => line + ", " + fruit);

      Console.WriteLine($"line = {line} ");

      /*출력
      line = apple, mango, orange, passionfruit, grape 
      */
    }

    public static void GetAttemptedWithdrawals()
    {
      double startBalance = 100.0;

      int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 };

      double endBalance = attemptedWithdrawals.Aggregate(startBalance,
                    (balance, nextWithdrawal) =>
                      ((nextWithdrawal <= balance) ? (balance - nextWithdrawal) : balance));

      Console.WriteLine($"endBalance = {endBalance} ");

      /*출력
      endBalance = 20
      */
    }
  }
}