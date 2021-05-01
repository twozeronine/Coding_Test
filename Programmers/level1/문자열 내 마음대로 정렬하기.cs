using System;
using System.Linq;

public class PickString
{
  public static string[] solution(string[] strings, int n)
  {
    answer = (from str in strings
              orderby (str, idx) => str[n])
    string[] answer = new string[] { };
    return answer;
  }
}