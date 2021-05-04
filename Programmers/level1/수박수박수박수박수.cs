using System;

class WaterMelon
{
  public static string solution(int n)
  {
    if (n == 1) return "수";
    if (n == 2) return "수박";
    string answer = "수박";
    for (int i = 3; i <= n; i++)
    {
      answer += i % 2 != 0 ? "수" : "박";
    }
    return answer;
  }


  // 다른 사람의 풀이 
  public string other_solution(int n)
  {
    // 1. n/2 +1 만큼의 char 생성. 
    // 2. char 1개당 "수박"하나씩
    // 3. Substring으로 n까지 잘라냄. 
    return new String(new char[n / 2 + 1]).Replace("\0", "수박").Substring(0, n);
  }
}