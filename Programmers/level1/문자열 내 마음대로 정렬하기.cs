using System;
using System.Linq;

public class PickString
{
  public static string[] solution(string[] strings, int n)
  {
    string[] answer = new string[strings.Length];

    for (int i = 0; i < strings.Length; i++)
    {
      answer[i] = strings[i][n] + strings[i];
    }
    Array.Sort(answer);
    for (int i = 0; i < strings.Length; i++)
    {
      answer[i] = answer[i].Substring(1);
    }
    return answer;
  }


  // 다른 사람 풀이
  public static string[] other_solution(string[] strings, int n)
  {
    //n번째 문자열을 비교한뒤 사전순으로 다시 또 비교. 
    string[] answer = strings.OrderBy(c => c[n]).ThenBy(c => c).ToArray();
    return answer;
  }
}