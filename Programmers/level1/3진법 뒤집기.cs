using System;
using System.Collections.Generic;

public class TernaryReverse
{
  public static int solution(int n)
  {
    if (n < 3) return n;
    int answer = 0;
    double temp = 0;
    List<int> ternary = new List<int>();
    while (n > 0)
    {
      ternary.Add(n % 3);
      n = n / 3;
    }
    for (int i = 0; i < ternary.Count; i++)
    {
      temp += ternary[i] * Math.Pow(3, ternary.Count - i - 1);
    }
    answer = (int)temp;
    return answer;
  }


  // 다른사람 풀이 
  public int other_solution(int n)
  {
    int answer = 0;
    while (n > 0)
    {
      answer *= 3;
      answer += n % 3;
      n /= 3;
    }
    return answer;
  }
}