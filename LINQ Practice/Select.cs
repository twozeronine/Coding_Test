using System;
using System.Linq;
using System.Collections.Generic;

public class Select
{

    //Select 절
    // 입력 시퀀스에 1을 더하여 출력 시퀀스를 만듭니다
    public static void PrintSequence()
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        var numPlusOne = from n in numbers
                         select n + 1;

        Console.Write($"numPlusOne = [ ");
        foreach (var number in numPlusOne)
        {
            Console.Write($" {number} ");
        }
        Console.WriteLine(" ] ");

        /* 출력
            numPlusOne = [  6  5  2  4  10  9  7  8  3  1  ] 
        */
    }

    //하나의 속성만 선택하기
    // products 객체로 이루어진 입력 시퀀스에서 ProductsName 속성으로 출력 시퀀스를 만듭니다
    public struct Product
    {
        public string ProductName;
        public string ProductID;
    }

    public static void SelectOneField()
    {
        List<Product> products = new List<Product>() {
                new Product(){ProductName="상자",ProductID= "1"},
                new Product(){ProductName="모니터",ProductID= "2"},
                new Product(){ProductName="컴퓨터",ProductID= "3"},
                new Product(){ProductName="시계",ProductID= "4"},
                new Product(){ProductName="가방",ProductID= "5"},
            };

        var productNames = from product in products
                           select product.ProductName;

        foreach (var Name in productNames)
        {
            Console.Write($" {Name} ");
        }
        Console.WriteLine();

        /*출력
         상자  모니터  컴퓨터  시계  가방 
        */
    }


    //다른 타입으로 출력 바꾸기
    // numbers 배열을 활용해 문자로 표현된 숫자 출력 시퀀스를 만듭니다
    public static void SwapPrint()
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        var textNums = from n in numbers
                       select strings[n];

        Console.Write($"textNums = [ ");
        foreach (var number in textNums)
        {
            Console.Write($" {number} ");
        }
        Console.WriteLine(" ] ");

        /*출력
         textNums = [  five  four  one  three  nine  eight  six  seven  two  zero  ] 
        */
    }

    //출력에 익명 형식 활용하기
    // 입력 시퀀스를 Select 절에서 new 생성자를 활용해 Upper 속성과 Lower 속성을 가진 익명 형식의 출력 시퀀스를 생성합니다.
    public static void SortWordsCase()
    {
        string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

        var upperLowerWords = from w in words
                              select new { Upper = w.ToUpper(), Lower = w.ToLower() };

        Console.Write($"upperLowerWords = [ ");
        foreach (var word in upperLowerWords)
        {
            Console.Write("{" + $" {word.Upper} , {word.Lower} " + "}");
        }
        Console.WriteLine(" ] ");

        /*출력
        upperLowerWords = [ { APPLE , apple }{ BLUEBERRY , blueberry }{ CHERRY , cherry } ] 
        */
    }

    //C# 7.0 버전부터 Tuple로도 출력을 투영할 수 있습니다. 출력은 System.ValueTuple 형식을 가진 System.Collection.IEnumeralbe 시퀀스가 됩니다.
    public static void DigitOddEven()
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        var digitOddEvens = from n in numbers
                            select (Digit: strings[n], Even: (n % 2 == 0));

        Console.Write($"digitOddEvens = [ ");
        foreach (var number in digitOddEvens)
        {
            Console.WriteLine($"[ Digit : {number.Digit}, Even : {number.Even} ]");
        }
        Console.WriteLine(" ] ");

        /*출력 
        digitOddEvens = [ [ Digit : five, Even : False ]
                          [ Digit : four, Even : True ]
                          [ Digit : one, Even : False ]
                          [ Digit : three, Even : False ]
                          [ Digit : nine, Even : False ]
                          [ Digit : eight, Even : True ]
                          [ Digit : six, Even : True ]
                          [ Digit : seven, Even : False ]
                          [ Digit : two, Even : True ]
                          [ Digit : zero, Even : True ]
                        ] 
        */
    }

    //새로운 타입 생성하기
    // 익명 형식을 활용하여 새로운 타입으로 출력을 투영합니다.
    // 하지만 C# 7.0 이후부터는 튜플 형식을 활용하는게 언어적인 이점이 많으므로 참고하자.
    public static void DigitOddEven2()
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        var digitOddEvens = from n in numbers
                            select (Digit: strings[n], Even: (n % 2 == 0));
        //select(Digit: strings[n], Even: (n % 2 ==0));
        Console.Write($"digitOddEvens = [ ");
        foreach (var number in digitOddEvens)
        {
            Console.WriteLine($"[ Digit : {number.Digit}, Even : {number.Even} ]");
        }
        Console.WriteLine(" ] ");

        /*출력 
        digitOddEvens = [ [ Digit : five, Even : False ]
                          [ Digit : four, Even : True ]
                          [ Digit : one, Even : False ]
                          [ Digit : three, Even : False ]
                          [ Digit : nine, Even : False ]
                          [ Digit : eight, Even : True ]
                          [ Digit : six, Even : True ]
                          [ Digit : seven, Even : False ]
                          [ Digit : two, Even : True ]
                          [ Digit : zero, Even : True ]
                        ] 
        */
    }



}
