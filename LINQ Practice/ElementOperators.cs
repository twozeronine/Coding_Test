using System;
using System.Linq;
using System.Collections.Generic;

public class ElementOperators
{
    // 주어진 조건으로 검색된 첫 번째 요소 찾기

    public class Product
    {
        public Product()
        {
            ProductID = 0;
        }
        public int ProductID = 0;
    }
    public static void GetFirstProduct()
    {
        List<Product> products = new List<Product>(){
            new Product(){ProductID=1},
            new Product(){ProductID=12},
            new Product(){ProductID=3},
            new Product(){ProductID=4},
            new Product(){ProductID=12},
            new Product(){ProductID=6},
            new Product(){ProductID=7},
            new Product(){ProductID=12},
            };

        Product product12 = (from p in products
                             where p.ProductID == 12
                             select p)
                            .First();


        Console.WriteLine($"product12 = {product12.ProductID} ");


        /* 출력
        product12 = 12 
        */
    }

    public static void FindStartsWithO()
    {
        string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        string startsWithO = strings.First(s => s[0] == 'o');

        Console.WriteLine($"startsWithO = {startsWithO} ");

        /* 출력
        startsWithO = one 
        */
    }

    //주어진 조건에 맞는 첫 번째 요소가 없을 경우 디폴트 값 받기
    // 만약 입력 시퀀스가 비어 있거나 조건에 맞는 값이 없을 경우, 디폴트 값을 반환합니다 

    public static void FindNumerOrDefault()
    {
        int[] numbers = { };

        int firstNumOrDefault = numbers.FirstOrDefault();

        // numbers 배열이 비어 있으므로 int의 디폴트 값인 0을 할당함.

        Console.WriteLine($"firstNumOrDefault = {firstNumOrDefault} ");
        /*출력 
        firstNumOrDefault = 0 
        */
    }

    public static void FindProductOrDefault()
    {
        List<Product> products = new List<Product>(){
            new Product(){ProductID= 1},
            new Product(){ProductID= 2},
            new Product(){ProductID= 3},
            new Product(){ProductID= 4},
            new Product(){ProductID= 5},
            };

        // 만약 products 리스트에 ProductID 속성이 789인 요소가 있을 경우, 해당 요소를 반환함
        // 없을 경우, Product 기본 생성자로 생성된 객체를 반환함.
        Product product789 = products.FirstOrDefault(p => p.ProductID == 789);

        Console.WriteLine($"product789 = {product789} ");
    }

    // 특정 위치에 있는 요소 찾기
    public static void FindFourthLowNumber()
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        int fourthLowNum = (
            from n in numbers
            where n > 5
            select n
        ).ElementAt(1);

        Console.WriteLine($"fourthLowNum = {fourthLowNum} ");

        /*출력 
        fourthLowNum = 8 
        */
    }
}