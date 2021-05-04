using System.Collections.Generic;
using System;
public class FindPrimeNumber
{
  //에라토스테네스의 체
  public static int solution(int n)
  {
    int answer = 0;

    // 1. 검사할 숫자  n+1만큼의 배열 크기 선언 초기화
    int[] PrimeNumberArray = new int[n + 1];
    for (int i = 2; i <= n; i++)
    {
      PrimeNumberArray[i] = i;
    }

    // 2. 2부터 시작해서 특정 수의 배수에 해당하는 수를 모두 지운다.
    //    자기 자신은 지우지 않고, 이미 지워진 수는 건너뛴다.

    for (int i = 2; i <= n; i++)
    {
      if (PrimeNumberArray[i] == 0) continue; // 이미 지워진 수.

      // 이미 지워진 숫자가 아니라면, 그 배수부터 출발하여, 가능한 모든 숫자 지우기
      for (int j = 2 * i; j <= n; j += i)
      {
        PrimeNumberArray[j] = 0;
      }
    }

    // 3. 2부터 시작하여 남아있는 수를 모두 더함.
    for (int i = 2; i <= n; i++)
    {
      if (PrimeNumberArray[i] != 0) answer++;
    }
    return answer;
  }


  //나의 예전 풀이 
  public int solution1(int n)
  {
    int answer = 1;
    List<double> PrimeNumberList = new List<double>();
    for (int i = 3; i <= n; i++)
    {
      if (PrimeNumberList.Contains(i)) continue;
      if (check(i))
      {
        answer++;
      }
    }
    return answer;
  }
  public bool check(int number)
  {
    int count = 0;
    for (int i = 2; i <= number; i++)
    {
      count = number % i == 0 ? ++count : count;
      if (count == 2) break;
    }
    return count == 1 ? true : false;
  }
}

