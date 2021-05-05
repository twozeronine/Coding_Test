using System;

public class Squareroot
{
  public static long solution(long n)
  {
    var num = Math.Sqrt(n);
    return num % 1 > 0 ? -1 : (long)Math.Pow(num + 1, 2);
  }
}