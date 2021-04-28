// 괄호 회전하기 문제

using System;
using System.Collections.Generic;

class test2
{
  static void Main(string[] args)
  {
    string case1;
    case1 = "}]()[{";
    Console.WriteLine(solution(case1));
  }
  public static int solution(string s)
  {
    int count = 0;
    if (s.Length % 2 != 0 || isOnlyClose(s)) return 0;

    for (int i = 0; i < s.Length; i++)
    {
      if (check(s)) count++;
      Rotate(s, out s);
    }
    return count;
  }

  public static void Rotate(string s, out string out_s)
  {
    out_s = s;
    out_s += s[0];
    out_s = out_s.Substring(1);
  }


  public static bool isOnlyClose(string s)
  {
    foreach (char c in s)
    {
      if (c.Equals('[') || c.Equals('{') || c.Equals('(')) return false;
    }
    return true;
  }

  public static bool check(string s)
  {
    Stack<char> stack = new Stack<char>();
    for (int i = 0; i < s.Length; i++)
    {
      switch (s[i])
      {
        case '[':
          {
            stack.Push('[');
            break;
          }
        case '{':
          {
            stack.Push('{');
            break;
          }
        case '(':
          {
            stack.Push('(');
            break;
          }
        case ']':
          {
            if (stack.Count == 0) return false;
            if (stack.Peek().Equals('[')) stack.Pop();
            break;
          }
        case '}':
          {
            if (stack.Count == 0) return false;
            if (stack.Peek().Equals('{')) stack.Pop();
            break;
          }
        case ')':
          {
            if (stack.Count == 0) return false;
            if (stack.Peek().Equals('(')) stack.Pop();
            break;
          }
      }
    }
    return stack.Count == 0 ? true : false;
  }
}
