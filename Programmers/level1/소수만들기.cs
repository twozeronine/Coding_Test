using System;

class PrimeNumeber
{
  public static int solution(int[] nums)
  {
    int answer = 0;
    for (int i = 0; i < nums.Length - 2; i++)
    {
      for (int j = i + 1; j < nums.Length - 1; j++)
      {
        for (int k = j + 1; k < nums.Length; k++)
        {
          answer = check(nums[i] + nums[j] + nums[k]) ? ++answer : answer;
        }
      }
    }
    return answer;
  }

  public static bool check(int number)
  {
    int count = 0;
    for (int i = 2; i <= number; i++)
    {

      count = number % i == 0 ? ++count : count;
    }
    return count == 1 ? true : false;
  }
}