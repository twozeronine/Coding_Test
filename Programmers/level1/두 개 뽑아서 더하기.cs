using System;
using System.Collections.Generic;
using System.Linq;

public class PickTwoSum
{
  public static int[] solution(int[] numbers)
  {
    List<int> answer = new List<int>();
    for (int i = 0; i < numbers.Length - 1; i++)
    {
      for (int j = i + 1; j < numbers.Length; j++)
      {
        answer.Add(numbers[i] + numbers[j]);
      }
    }
    return (from item in answer
            orderby item
            select item).Distinct().ToArray();
  }


  //다른 사람 풀이 ( 평균 속도 2.3ms )
  public int[] other_solution(int[] numbers)
  {
    List<int> answerList = new List<int>();

    for (int i = 0; i < numbers.Length - 1; ++i)
    {
      for (int j = i + 1; j < numbers.Length; ++j)
        if (!answerList.Contains(numbers[i] + numbers[j]))
          answerList.Add(numbers[i] + numbers[j]);
    }

    answerList.Sort();

    return answerList.ToArray();
  }
}