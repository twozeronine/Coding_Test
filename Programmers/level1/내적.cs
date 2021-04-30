using System;
using System.Linq;

public class DotProduct
{
  public static int solution(int[] a, int[] b)
  {
    int answer = 0;
    for (int i = 0; i < a.Length; i++) answer += a[i] * b[i];
    return answer;
  }
}