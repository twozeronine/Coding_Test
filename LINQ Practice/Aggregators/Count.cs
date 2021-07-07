using System;
using System.Linq;
using System.Collections.Generic;

namespace Aggregators
{
    public class Count
    {
        //  Distinct 메서드로 중복되는 값 제거후 숫자 세기
        public static void DistinctCount()
        {
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };

            int uniqueFactors = factorsOf300.Distinct().Count();

            Console.WriteLine($"uniqueFactors = {uniqueFactors} ");

            /* 출력
            uniqueFactors = 3
            */
        }

        public static void GetOddNumbersCount()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int oddNumbers = numbers.Count(n => n % 2 == 1);

            Console.WriteLine($"oddNumbers = {oddNumbers} ");

            /* 출력
            oddNumbers = 5
            */
        }
    }


}