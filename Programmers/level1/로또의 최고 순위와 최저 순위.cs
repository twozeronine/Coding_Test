using System;
using System.Linq;

public class lotto
{
  enum Rank { First = 6, Second = 5, Third = 4, Fourth = 3, Fifth = 2 }
  public static int[] solution(int[] lottos, int[] win_nums)
  {
    int[] answer = new int[2];

    int win = lottos.Intersect(win_nums).ToArray().Count();
    int unknown =
        (from lotto in lottos
         where lotto == 0
         select lotto).ToArray().Count();

    for (int i = 0; i < answer.Length; i++)
    {
      switch (i == 0 ? win + unknown : win)
      {
        case ((int)Rank.First): answer[i] = 1; break;
        case ((int)Rank.Second): answer[i] = 2; break;
        case ((int)Rank.Third): answer[i] = 3; break;
        case ((int)Rank.Fourth): answer[i] = 4; break;
        case ((int)Rank.Fifth): answer[i] = 5; break;
        default: answer[i] = 6; break;
      }
    }
    return answer;
  }


  //다른사람 풀이법
  public int[] other_solution(int[] lottos, int[] win_nums)
  {
    int winCount = lottos.Intersect(win_nums).Count();
    int loseCount = lottos.Where((number) => number != 0).Count() - winCount;

    int[] answer = new int[] { WinCountToRank(6 - loseCount), WinCountToRank(winCount) };
    return answer;
  }

  public int WinCountToRank(int count)
  {
    if (count <= 1)
    {
      return 6;
    }

    return 7 - count;
  }
}