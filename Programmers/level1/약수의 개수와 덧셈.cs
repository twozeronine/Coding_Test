using System;

public class GetDivisionNumber
{
    public static int solution2(int left, int right)
    {
        int answer = 0;

        for (int i = left; i <= right; i++)
        {
            answer += GetNumber(i);
        }

        return answer;
    }

    public static int GetNumber(int number)
    {
        var count = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
                count++;
        }
        return count % 2 == 0 ? -number : number;
    }
}

