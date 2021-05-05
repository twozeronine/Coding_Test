using System.Linq;

public class Naturalnumber
{
  public static int[] solution(long n)
  {
    return n.ToString().Select(item => item - '0').Reverse().ToArray();
  }
}