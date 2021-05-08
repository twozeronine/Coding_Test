using System.Linq;

public class HashadNumber
{
  public static bool solution(int x) => x % x.ToString().Select(e => e - '0').Sum() == 0 ? true : false;
}