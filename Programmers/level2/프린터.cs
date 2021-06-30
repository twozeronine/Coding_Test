using System;
using System.Collections.Generic;
using System.Linq;

public class Printer
{
    public static int solution(int[] priorities, int location)
    {
        int answer = 0;
        Queue<KeyValuePair<int, int>> que = new Queue<KeyValuePair<int, int>>();
        for (int i = 0; i < priorities.Length; i++)
        {
            que.Enqueue(new KeyValuePair<int, int>(i, priorities[i]));
        }
        while (true)
        {
            int nMax = que.Max(x => x.Value);
            var kv = que.Dequeue();
            if (kv.Value == nMax)
            {
                if (kv.Key == location) return answer + 1;
                else
                {
                    answer++;
                    continue;
                }
            }
            que.Enqueue(kv);
        }
    }
}