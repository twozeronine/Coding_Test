using System;

public class integer
{
  public static long solution(int a, int b)
  {
    if (a == b) return a;
    return a > b ? sum(a, b) : sum(b, a);
  }

  public static long sum(int greater, int smaller)
  {
    long result = 0;
    for (int i = smaller; i <= greater; i++)
    {
      result += i;
    }
    return result;
  }
}