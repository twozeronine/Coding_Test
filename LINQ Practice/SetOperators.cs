using System;
using System.Linq;
using System.Collections.Generic;

public class SetOperators
{
  //집합 내에 중복 요소 제거하기
  //Distinct 메서드로 factorsOf300 배열에서 중복을 제거한 uniqueFactors 배열을 만듭니다.
  public static void RemoveOverlap()
  {
    int[] factorsOf300 = { 2, 2, 3, 5, 5 };

    var uniqueFactors = factorsOf300.Distinct();

    Console.Write($"uniqueFactors = [ ");
    foreach (var number in uniqueFactors)
    {
      Console.Write($" {number} ");
    }
    Console.WriteLine(" ] ");

    /* 출력
    uniqueFactors = [  2  3  5  ] 
    */
  }

  // 두 집합에서 중복되지 않게 합집합 만들기
  // Union 메서드는 두 집합을 각 원소가 중복되지 않도록 더한 새로운 집합을 만듭니다.
  public static void UnionNumbers()
  {
    int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
    int[] numbersB = { 1, 3, 5, 7, 8 };

    var uniqueNumbers = numbersA.Union(numbersB);

    Console.Write($"uniqueNumbers = [ ");
    foreach (var number in uniqueNumbers)
    {
      Console.Write($" {number} ");
    }
    Console.WriteLine(" ] ");

    /* 출력
    uniqueNumbers = [  0  2  4  5  6  8  9  1  3  7  ] 
    */
  }

  // 두 집합 간에 중복되는 요소만 모으기
  // Intersect 메서드는 두 집합에서 중복되는 원소만 모아서 새로운 집합을 만듭니다.
  public static void IntersectNumbers()
  {
    int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
    int[] numbersB = { 1, 3, 5, 7, 8 };

    var commonNumbers = numbersA.Intersect(numbersB);

    Console.Write($"commonNumbers = [ ");
    foreach (var number in commonNumbers)
    {
      Console.Write($" {number} ");
    }
    Console.WriteLine(" ] ");

    /* 출력
    commonNumbers = [  5  8  ]
    */
  }

  // A 집합에는 있지만 B집합에는 없는 요소만 모으기 
  // Except 메서드는 기준이 되는 A 집합에만 존재하며 B 집합에 존재하지 않는 원소만 모아서 새로운 집합을 만듭니다.
  // 집합 A - B 
  public static void ExceptNumbers()
  {
    int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
    int[] numbersB = { 1, 3, 5, 7, 8 };

    var aOnlyNumbers = numbersA.Except(numbersB);

    Console.Write($"aOnlyNumbers = [ ");
    foreach (var number in aOnlyNumbers)
    {
      Console.Write($" {number} ");
    }
    Console.WriteLine(" ] ");

    /* 출력
    aOnlyNumbers = [  0  2  4  6  9  ]
    */
  }
}