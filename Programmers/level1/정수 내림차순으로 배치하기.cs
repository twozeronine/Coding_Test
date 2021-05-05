using System.Linq;

public class Sortinteger
{
  public static long solution(long n)
  {
    var result = string.Concat(n.ToString().OrderByDescending(e => e));
    return long.Parse(result);
  }
}