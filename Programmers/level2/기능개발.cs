using System;
using System.Linq;
using System.Collections.Generic;

public class DevelopFunction
{
  public static int[] solution(int[] progresses, int[] speeds)
  {
    List<int> answer = new List<int>();
    Queue<int> progressQue = new Queue<int>(progresses);
    Queue<int> speedsQue = new Queue<int>(speeds);

    int Count = 0;
    while (progressQue.Count > 0)
    {
      for (int i = 0; i < progressQue.Count; ++i)
      {
        int temp_process = progressQue.Dequeue();

        temp_process += speedsQue.ElementAt(i);

        progressQue.Enqueue(temp_process);
      }

      if (progressQue.Count > 0)
      {
        while (progressQue.Peek() >= 100)
        {
          progressQue.Dequeue();
          Count++;

          speedsQue.Dequeue();

          if (progressQue.Count == 0) break;
        }
      }

      if (Count > 0)
      {
        answer.Add(Count);
        Count = 0;
      }
    }
    return answer.ToArray();
  }


  // 다른 사람의 풀이
  public static int[] otherSolution(int[] progresses, int[] speeds)
  {
    int[] answer = new int[] { };

    var tmp = progresses.Select((item, idx) => (int)Math.Ceiling((double)(100 - item) / speeds[idx]));

    List<int> deploy = new List<int>();
    List<int> Remains = new List<int>();

    int lastBig = -1;
    foreach (int itm in tmp)
    {
      if (lastBig < itm)
        lastBig = itm;

      deploy.Add(lastBig);
    }

    var tmp2 = from itm in deploy
               group itm by itm into g
               select new
               {
                 CNT = g.Count()
               };

    answer = tmp2.Select(x => x.CNT).ToArray();

    return answer;
  }
}
