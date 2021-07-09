using System;
using System.Linq;
using System.Collections.Generic;

public class SequenceOperations
{
    // 두 집합의 모든 요소가 같은 순서대로 있는지 비교하기
    public static void isMatch()
    {
        var wordsA = new string[] { "cherry", "apple", "blueberry" };
        var wordsB = new string[] { "cherry", "apple", "blueberry" };
        var wordsC = new string[] { "apple", "blueberry", "cherry" };

        bool matchA_B = wordsA.SequenceEqual(wordsB);
        bool matchA_C = wordsA.SequenceEqual(wordsC);



        Console.Write($"matchA_B : [ {matchA_B}");
        Console.WriteLine(" ] ");
        Console.Write($"matchA_C : [ {matchA_C}");
        Console.WriteLine(" ] ");
        /* 출력
        matchA_B : [ True ] 
        matchA_C : [ False ] 
        */
    }

    // 두 집합 연결하기
    public static void ConcatNumbers()
    {
        int[] numberA = { 0, 2, 4, 5, 6, 8, 9 };
        int[] numberB = { 1, 3, 5, 7, 8 };

        var allNumbers = numberA.Concat(numberB);

        Console.Write($"allNumbers : [ ");
        foreach (var number in allNumbers)
        {
            Console.Write($"{number}, ");
        }
        Console.WriteLine(" ] ");

        /* 출력
        allNumbers : [ 0, 2, 4, 5, 6, 8, 9, 1, 3, 5, 7, 8,  ] 
        */
    }

    //Enumerable.Zip
    // Enumerable.Zip 메서드는 집합 A의 모든 요소와 집합 B의 모든 요소와 하나하나 대조하여 연결하는 메서드입니다. 주로 수학에서 백터의 내적 곱을 계산할 때 사용됩니다.
    public static void GetDotProduct()
    {
        int[] vectorA = { 0, 2, 4, 5, 6 };
        int[] vectorB = { 1, 3, 5, 7, 8 };

        int dotProduct = vectorA.Zip(vectorB, (a, b) => a * b).Sum();

        Console.Write($"dotProduct : [ {dotProduct}");
        Console.WriteLine(" ] ");

        /* 출력
       dotProduct : [ 109 ] 
        */
    }

}

