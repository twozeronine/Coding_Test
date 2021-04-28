// 음양 더하기 문제

using System;



class test1
{
  //   static void Main(string[] args)
  //   {
  //     int[] absolutes = new int[3] { 4, 7, 12 };
  //     bool[] signs = new bool[3] { true, false, true };
  //     Console.WriteLine(solution(absolutes, signs));
  //   }
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
