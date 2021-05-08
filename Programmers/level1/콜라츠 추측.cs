using System;

public class Collatz
{
  public static int solution(int num)
  {
    int count = 0;
    long lnum = num;

    while (lnum != 1 && count != 500)
    {
      lnum = lnum % 2 == 0 ? lnum / 2 : (lnum * 3) + 1;
      count++;
    }
    return count == 500 ? -1 : count;
  }
}
