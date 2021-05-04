using System.Linq;

public class CaesarCipher
{
  public static string solution(string s, int n)
  {


    int[] ascii = new int[s.Length];
    string answer = "";
    for (int i = 0; i < s.Length; i++)
    {
      int ch = (int)s[i];

      //공백
      if (ch == 32)
      {
        ascii[i] = ch;
      }
      // 소문자 
      // 97~122 a~z
      else if (ch <= 122 && ch >= 97)
      {
        ascii[i] = ch + n > 122 ? (ch + n) % 123 + 97 : ch + n;
      }
      //대문자
      // 65~90 A~Z
      else if (ch <= 90 && ch >= 65)
      {
        ascii[i] = ch + n > 90 ? (ch + n) % 91 + 65 : ch + n;
      }
    }
    for (int i = 0; i < ascii.Length; i++)
    {
      answer += (char)ascii[i];
    }
    return answer;
  }


  // Linq를 사용한 다른사람의 풀이
  public string other_solution(string s, int n)
  {
    return string.Concat(s.ToCharArray().Select(r =>
        {
          int ret = r;
          if (r >= 'a' && r <= 'z')
          {
            ret = (r + n - 'a') % 26 + 'a';
          }
          if (r >= 'A' && r <= 'Z')
          {
            ret = (r + n - 'A') % 26 + 'A';
          }

          return (char)ret;
        }).ToList());
  }
}

