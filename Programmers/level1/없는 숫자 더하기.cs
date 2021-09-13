using System;
using System.Linq;

public class GetExceptNumbers
{
    public static int solution(int[] numbers)
    {
        var numberArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        return numberArray.Except(numbers).Sum();
    }
}