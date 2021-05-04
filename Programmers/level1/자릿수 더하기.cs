using System;

public class digitsum
{
  public static int solution(int n)
  {
    char[] temp = n.ToString().ToCharArray();
    int answer = 0;
    for (int i = 0; i < temp.Length; i++)
    {
      answer += temp[i] - '0';
    }
    return answer;
  }

  public int other_solution(int n)
  {
    int answer = 0;

    while (n > 0)
    {
      answer += n % 10;
      n = n / 10;
    }
    return answer;
  }
}