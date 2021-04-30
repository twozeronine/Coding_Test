using System;
using System.Collections.Generic;
using System.Linq;

public class Divisor
{
  public static int[] solution(int[] arr, int divisor)
  {
    if (divisor == 1)
    {
      Array.Sort(arr);
      return arr;
    }
    List<int> answer = new List<int>();
    for (int i = 0; i < arr.Length; i++)
    {
      if (arr[i] % divisor == 0) answer.Add(arr[i]);
    }
    if (answer.Count == 0) answer.Add(-1);
    answer.Sort();
    return answer.ToArray();
  }

  // LINQ버전으로 만들어 본거 
  public static int[] Linq_solution(int[] arr, int divisor)
  {
    var answer = from num in arr
                 where num % divisor == 0
                 orderby num
                 select num;

    var fail = new int[] { -1 };
    return answer.Count() == 0 ? fail : answer.ToArray();
  }
}