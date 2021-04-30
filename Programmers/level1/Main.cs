using System;

class MainApp
{
  static void Main(string[] args)
  {
    // 모의고사

    int[] a = { 1, 3, 2, 4, 2 };
    var result = test.solution(a);
    Console.Write("모의고사 정답 : ");
    foreach (var student in result)
    {
      Console.Write(student);
    }

    Console.WriteLine();

    // K번째수 

    int[] array = { 1, 5, 2, 6, 3, 7, 4 };
    int[,] commands = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };
    var result2 = Knumber.solution8(array, commands);
    Console.Write("K번째수 정답 : ");
    foreach (var num in result2)
    {
      Console.Write(num);
    }
    Console.WriteLine();

    // 체육복
    int n = 5;
    int[] lost = { 2, 4 };
    int[] reserve = { 1, 3, 5 };
    var result3 = trainingclothes.solution(n, lost, reserve);
    Console.WriteLine($"체육복 정답 :{result3}");

    // 2016년
    int month = 9;
    int days = 14;
    var result4 = year2016.solution(month, days);
    result4 = year2016.other_solution(month, days);
    Console.WriteLine($"2016년 정답 : {result4}");


    //가운데 글자 가져오기
    string words = "a";
    var result5 = MiddleNumber.solution(words);
    Console.WriteLine($"가운데 글자 가져오기 정답 : {result5}");
  }
}