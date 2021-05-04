using System;

public class WhereisKim
{
  public static string solution(string[] seoul)
  {
    int Kimindex = Array.FindIndex(seoul, idx => idx == "Kim");
    return $"김서방은 {Kimindex}에 있다";
  }
}

