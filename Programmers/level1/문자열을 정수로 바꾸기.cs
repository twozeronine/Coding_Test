class ParseStringtoInt
{
  //C# 8.0에서 지원하는 switch식으로 푼 문제
  public static int solution8(string s)
  {
    var cutS = s.Substring(1);
    int answer = int.TryParse(s, out int number) ? number : s[0] switch
    {
      '+' => int.Parse(cutS),
      '-' => -int.Parse(cutS),
      _ => 0,
    };
    return answer;
  }

  public static int solution(string s)
  {
    var cutS = s.Substring(1);
    int answer = int.TryParse(s, out int number) ? number : s[0] == '+' ? int.Parse(cutS) : -int.Parse(cutS);
    return answer;
  }

  // ↑ 애초에 다 True값이 나옴


  // 다른 사람 풀이 
  public static int other_solution(string s)
  {
    return int.Parse(s);
  }
}