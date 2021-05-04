using System.Linq;
using System;

public class MakeStrangeString
{
  public static string solution(string s)
  {
    string[] chararray = s.Split(new char[] { ' ' });
    for (int i = 0; i < chararray.Length; i++)
    {
      chararray[i] = string.Concat(chararray[i].ToCharArray().Select((c, idx) =>
      {
        int ascii = c;
        if (ascii >= 'a' && ascii <= 'z')
          ascii = idx % 2 == 0 ? c - 32 : c;
        else if (ascii >= 'A' && ascii <= 'Z')
          ascii = idx % 2 == 0 ? c : c + 32;
        return (char)ascii;
      }));
    }
    string result = string.Join(' ', chararray);
    return result;
  }


  //다른사람 풀이
  public string other_solution(string s)
  {
    string answer = "";
    int num = 0;

    for (int i = 0; i < s.Length; i++)
    {
      answer += num % 2 == 0 ? s[i].ToString().ToUpper() : s[i].ToString().ToLower();

      num = s[i] == ' ' ? 0 : num + 1;

    }
    return answer;
  }
}