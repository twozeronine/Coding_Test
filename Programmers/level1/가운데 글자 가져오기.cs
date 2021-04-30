
using System;

class MiddleNumber
{
  public static string solution(string s)
  {
    var middle = s.Length / 2;
    return s.Length % 2 == 0 ? s.Substring(middle - 1, 2) : s.Substring(middle, 1);
  }
}