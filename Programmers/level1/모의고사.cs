using System;
using System.Linq;
using System.Collections.Generic;
class test
{
  // static void Main(string[] args)
  // {
  //   int[] a = { 1, 3, 2, 4, 2 };
  //   var result = solution(a);
  //   foreach (var student in result)
  //   {
  //     Console.Write(student);
  //   }
  // }

  public static int[] solution(int[] answers)
  {
    List<int> answer = new List<int>();
    int[] student1 = { 1, 2, 3, 4, 5 };
    int[] student2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
    int[] student3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
    int[] score = new int[3] { 0, 0, 0 };
    var stu1PatternLength = student1.Length;
    var stu2PatternLength = student2.Length;
    var stu3PatternLength = student3.Length;
    for (int i = 0; i < answers.Length; i++)
    {
      score[0] = answers[i] == student1[i % stu1PatternLength] ? score[0] + 1 : score[0];
      score[1] = answers[i] == student2[i % stu2PatternLength] ? score[1] + 1 : score[1];
      score[2] = answers[i] == student3[i % stu3PatternLength] ? score[2] + 1 : score[2];
    }
    for (int i = 0; i < score.Length; i++)
    {
      if (score[i] == score.Max()) answer.Add(i + 1);
    }
    return answer.ToArray();
  }
}
