using System.Linq;

public class HashadNumber
{
  public static bool solution(int x) => x % x.ToString().Select(e => e - '0').Sum() == 0 ? true : false;



  //다른 사람의 풀이
  public bool other_solution(int x)
  {
    int sum = 0;
    int temp = x;
    while (temp > 0)
    {
      sum += temp % 10;
      temp = temp / 10;
    }

    return x % sum == 0;
  }
}