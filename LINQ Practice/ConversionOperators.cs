using System;
using System.Linq;
using System.Collections.Generic;

public class ConversionOperators
{
  //ToArray
  public static void ToArray()
  {
    double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

    var sortedDoubles = from d in doubles
                        orderby d descending
                        select d;
    var doublesArray = sortedDoubles.ToArray();

    Console.Write($"doublesArray = [ ");
    foreach (var number in doublesArray)
    {
      Console.Write($" {number} ");
    }
    Console.WriteLine(" ] ");

    /* 출력
    doublesArray = [  4.1  2.9  2.3  1.9  1.7  ] 
    */
  }

  // ToList
  public static void ToList()
  {
    string[] words = { "cherry", "apple", "blueberry" };

    var sortedWords = from w in words
                      orderby w
                      select w;

    var wordList = sortedWords.ToList();

    Console.Write($"wordList = [ ");
    foreach (var number in wordList)
    {
      Console.Write($" {number} ");
    }
    Console.WriteLine(" ] ");

    /* 출력
    wordList = [  apple  blueberry  cherry  ]
    */
  }

  // ToDictionary
  public static void ToDictionary()
  {
    var scoreRecords = new[] {new {Name = "Alice", Score = 50},
                              new {Name ="Bob",Score =40},
                              new {Name ="Cathy",Score =45},
                    };

    var scoreRecordsDict = scoreRecords.ToDictionary(sr => sr.Name);

    foreach (var number in scoreRecordsDict)
    {
      Console.Write($" Key : {number.Key}, Value.Name : {number.Value.Name}, Value.Score : {number.Value.Score} ");
      Console.WriteLine();
    }
    Console.WriteLine(" ] ");

    /* 출력
    scoreRecordsDict = [  
      Key : Alice, Value.Name : Alice, Value.Score : 50
      Key : Bob, Value.Name : Bob, Value.Score : 40
      Key : Cathy, Value.Name : Cathy, Value.Score : 45
    ]
    */
  }

  // OfType<T>
  // OfType<T>는 numbers 배열의 모든 요소를 T로 형변환함.
  public static void OfType()
  {
    object[] numbers = { null, 1.0, "two", 3, "four", 5, "six", 7.0, "문자" };

    var doubles = numbers.OfType<double>();

    Console.Write($"doubles = [ ");
    foreach (var number in doubles)
    {
      Console.Write($" {number} ");
    }
    Console.WriteLine(" ] ");

    /* 출력
    doubles = [  1  7  ]
    */
  }
}