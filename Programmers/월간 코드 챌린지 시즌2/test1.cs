// 음양 더하기 문제

using System;



class test1
{

  public static int solution(int[] absolutes, bool[] signs)
  {
    int answer = 0;
    for (int i = 0; i < absolutes.Length; i++)
    {
      answer += signs[i] ? absolutes[i] : -absolutes[i];
    }
    return answer;
  }
}
