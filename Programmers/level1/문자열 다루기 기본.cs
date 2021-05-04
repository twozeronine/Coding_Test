using System;
using System.Linq;

public class StringBasic
{
  public static bool solution(string s)
  {
    if (s.Length != 4 && s.Length != 6) return false;
    return int.TryParse(s, out int number);
  }
}

