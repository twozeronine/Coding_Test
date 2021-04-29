using System;

class MainApp
{
  static void Main(string[] args)
  {
    // 모의고사

    int[] a = { 1, 3, 2, 4, 2 };
    var result = test.solution(a);
    foreach (var student in result)
    {
      Console.Write(student);
    }

    Console.WriteLine();

    // K번째수 

    int[] array = { 1, 5, 2, 6, 3, 7, 4 };
    int[,] commands = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };
    var result2 = Knumber.solution9(array, commands);
    foreach (var num in result2)
    {
      Console.Write(num);
    }
  }
}