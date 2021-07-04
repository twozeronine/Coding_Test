using System;
using System.Linq;
using System.Collections.Generic;




public class OrderingOperator
{

  // 원소 정렬하기
  // 알파벳 순서로 정렬함.
  public static void SortedWords()
  {
    string[] words = { "cherry", "apple", "blueberry" };

    var sortedWords = from word in words
                      orderby word
                      select word;


    Console.Write($"sortedWords = [ ");
    foreach (var word in sortedWords)
    {
      Console.Write($" {word} ");
    }
    Console.WriteLine(" ] ");

    /*출력
    sortedWords = [  apple  blueberry  cherry  ] 
    */
  }


  //원소의 속성으로 정렬하기
  //string.Legth 속성을 사용하여 정렬함.
  public static void SortedWordsByLength()
  {
    string[] words = { "cherry", "apple", "blueberry" };

    var sortedWords = from word in words
                      orderby word.Length
                      select word;

    Console.Write($"sortedWords = [ ");
    foreach (var word in sortedWords)
    {
      Console.Write($" {word} ");
    }
    Console.WriteLine(" ] ");

    /*출력 
    sortedWords = [  apple  cherry  blueberry  ]
    */
  }

  public class Product
  {
    public string ProductName;
  }


  // 클래스의 속성으로 정렬하기
  // Product.ProductName 속성으로 정렬함.
  public static void SortedProductByName()
  {
    List<Product> products = new List<Product>()
    {
      new Product(){ProductName = "상자" },
      new Product(){ProductName = "휴대폰" },
      new Product(){ProductName = "컴퓨터" },
      new Product(){ProductName = "모니터" },
      new Product(){ProductName = "키보드" },
      new Product(){ProductName = "마우스" },
    };

    var sortedProducts = from prod in products
                         orderby prod.ProductName
                         select prod;

    Console.Write($"sortedProducts = [ ");
    foreach (var product in sortedProducts)
    {
      Console.Write($" {product.ProductName} ");
    }
    Console.WriteLine(" ] ");

    /*출력 
    sortedProducts = [  마우스  모니터  상자  컴퓨터  키보드  휴대폰  ]
    */
  }


  // 내림차순으로 정렬하기
  // descending 키워드로 내림차순 정렬함.
  public static void DescendingOrder()
  {
    double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

    var sortedDoubles = from d in doubles
                        orderby d descending
                        select d;

    Console.Write($"sortedDoubles = [ ");
    foreach (var number in sortedDoubles)
    {
      Console.Write($" {number} ");
    }
    Console.WriteLine(" ] ");

    /* 출력
    sortedDoubles = [  4.1  2.9  2.3  1.9  1.7  ]
    */
  }


  // 여러 기준으로 정렬하기
  // digit.Length로 정렬한 뒤, 알파벳 오름차순으로 정렬함.
  public static void Sorted2Condition()
  {
    string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

    var sortedDigits = from digit in digits
                       orderby digit.Length, digit
                       select digit;

    Console.Write($"sortedDigits = [ ");
    foreach (var digit in sortedDigits)
    {
      Console.Write($" {digit} ");
    }
    Console.WriteLine(" ] ");

    /* 출력 
    sortedDigits = [  one  six  ten  two  five  four  nine  zero  eight  seven  three  ]
    */
  }

  // 정렬 뒤집기
  // digits 배열 원소 중 두번째 문자가 'i'인 원소만 출력 시퀀스에 추가한 뒤, 출력 시퀀스 순서를 뒤집습니다.
  public static void ReversedDigit()
  {
    string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

    var reversedIDigits = (from digit in digits
                           where digit[1] == 'i'
                           select digit)
                          .Reverse();

    Console.Write($"reversedIDigits = [ ");
    foreach (var digit in reversedIDigits)
    {
      Console.Write($" {digit} ");
    }
    Console.WriteLine(" ] ");

    /* 출력
    reversedIDigits = [  nine  eight  six  five  ]
    */
  }

  // 비교 연산자를 구현해 활용하기
  // 먼저 비교 연산자를 구현

  public class CaseInsensitiveComparer : IComparer<string>
  {
    public int Compare(string x, string y) =>
        string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
  }
  // 구현된 비교 연산자를 LINQ OrderBy 메서드에 활용함.

  public static void SortedWordsByComparer()
  {
    string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "CHeRry" };

    var sortedWords = words.OrderBy(a => a, new CaseInsensitiveComparer());

    var sortedWordsReverse = words.OrderByDescending(a => a, new CaseInsensitiveComparer());


    Console.Write($"sortedWords = [ ");
    foreach (var word in sortedWords)
    {
      Console.Write($" {word} ");
    }
    Console.WriteLine(" ] ");

    Console.Write($"sortedWordsReverse = [ ");
    foreach (var word in sortedWordsReverse)
    {
      Console.Write($" {word} ");
    }
    Console.WriteLine(" ] ");

    /*출력 
    sortedWords = [  AbAcUs  aPPLE  BlUeBeRrY  bRaNcH  CHeRry  ClOvEr  ]
    sortedWordsReverse = [  ClOvEr  CHeRry  bRaNcH  BlUeBeRrY  aPPLE  AbAcUs  ]
    */
  }

  // 비교 연산자를 중첩해서 사용하기
  // OrderBy 메서드로 정렬 후에 ThenBy 연산자로 추가 정렬함.

  public static void SortedWordsByNestedComparer()
  {
    string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "CHeRry" };

    var sortedWords = words
        .OrderBy(a => a.Length)
        .ThenBy(a => a, new CaseInsensitiveComparer());

    var sortedWordsReverse = words
        .OrderBy(a => a.Length)
        .ThenByDescending(a => a, new CaseInsensitiveComparer());

    Console.Write($"sortedWords = [ ");
    foreach (var word in sortedWords)
    {
      Console.Write($" {word} ");
    }
    Console.WriteLine(" ] ");

    Console.Write($"sortedWordsReverse = [ ");
    foreach (var word in sortedWordsReverse)
    {
      Console.Write($" {word} ");
    }
    Console.WriteLine(" ] ");


    /* 출력
    sortedWords = [  aPPLE  AbAcUs  bRaNcH  CHeRry  ClOvEr  BlUeBeRrY  ]
    sortedWordsReverse = [  aPPLE  ClOvEr  CHeRry  bRaNcH  AbAcUs  BlUeBeRrY  ]
    */
  }
}