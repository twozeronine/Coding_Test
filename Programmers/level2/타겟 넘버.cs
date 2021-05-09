using System;
using System.Collections.Generic;
using System.Linq;

public class TargetNumber
{
  public static int solution(int[] numbers, int target)
  {
    return DFS(numbers, 0, 0, target);
  }
  public static int DFS(int[] numbers, int idx, int depth, int target)
  {
    if (idx == numbers.Length)
    {
      return depth == target ? 1 : 0;
    }
    else
    {
      return DFS(numbers, idx + 1, depth + numbers[idx], target) +
              DFS(numbers, idx + 1, depth - numbers[idx], target);
    }
  }

  //다른사람의 풀이
  public static int other_solution(int[] numbers, int target)
  {
    int answer = 0;
    List<int> lstFrom = new List<int>(new int[] { 0 });
    List<int> lstTo = new List<int>();
    for (int i = 0; i < numbers.Length; i++)
    {
      foreach (var num in lstFrom)
      {
        lstTo.Add(num + numbers[i]);
        lstTo.Add(num - numbers[i]);
      }
      lstFrom.Clear();
      lstFrom.AddRange(lstTo.ToArray());
      lstTo.Clear();
    }
    answer = lstFrom.Where(x => x == target).Count();
    return answer;
  }
}