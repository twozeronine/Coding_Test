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
        var result1 = DevelopFunction.otherSolution(progresses, speeds);
        Console.Write($"기능개발 정답 : ");
        foreach (var element in result1)
            Console.Write($"{element}, ");
        Console.WriteLine();
        #endregion

        #region  프린터

        // 프린터

        int[] priorities = { 2, 1, 3, 2 };
        int location = 2;
        var result2 = Printer.solution(priorities, location);
        Console.Write($"프린터 정답 : ");
        Console.WriteLine(result2);
        #endregion
    }
}

