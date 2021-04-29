using System;
using System.Linq;
using System.Collections.Generic;
class Knumber
{
  static void Main(string[] args)
  {
    int[] array = { 1, 5, 2, 6, 3, 7, 4 };
    int[,] commands = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };
    var result = solution9(array, commands);
    foreach (var num in result)
    {
      Console.Write(num);
    }
  }

  // C# 8.0에서 지원하는 System.Range 사용
  public static int[] solution9(int[] array, int[,] commands)
  {
    List<int> answer = new List<int>();
    int count = commands.GetLength(0);
    for (int i = 0; i < count; i++)
    {
      var cmd = new { First = commands[i, 0] - 1, Last = commands[i, 1], Pick = commands[i, 2] - 1 };
      int[] sliced = array[cmd.First..cmd.Last].OrderBy((num) => num).ToArray();
      answer.Add(sliced[cmd.Pick]);
    }
    return answer.ToArray();
  }

  // Array.Copy 사용
  public static int[] solution(int[] array, int[,] commands)
  {
    List<int> answer = new List<int>();
    int Length = commands.GetLength(0);
    for (int i = 0; i < Length; i++)
    {
      int first = commands[i, 0] - 1;
      int last = commands[i, 1];
      int count = last - first;
      int pickNumber = commands[i, 2] - 1;
      int[] sliced = new int[count];
      Array.Copy(array, first, sliced, 0, count);
      Array.Sort(sliced);
      answer.Add(sliced[pickNumber]);
    }
    return answer.ToArray();
  }
}
