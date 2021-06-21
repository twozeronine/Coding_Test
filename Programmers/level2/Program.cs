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

    #region  기능개발

    // 기능 개발

    int[] progresses = { 93, 30, 55 };
    int[] speeds = { 1, 30, 5 };
    var result1 = DevelopFunction.solution(progresses, speeds);
    foreach (var element in result1)
      Console.WriteLine(element);
    #endregion
  }
}

