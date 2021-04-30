using System;

public class Money
{
  public static int solution(int[] d, int budget)
  {
    Array.Sort(d);
    int answer = 0;
    foreach (int money in d)
    {
      if (budget - money < 0) break;
      budget -= money;
      answer++;
    }
    return answer;
  }
}