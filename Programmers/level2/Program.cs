using System;

class Program
{
  static void Main(string[] args)
  {
    #region 타겟 넘버

    // 타겟 넘버

    int[] numbers = { 1, 1, 1, 1, 1 };
    int target = 3;
    var result = TargetNumber.solution(numbers, target);
    Console.Write($"타겟 넘버 정답 : {result}");
    Console.WriteLine();
    #endregion
  }
}

