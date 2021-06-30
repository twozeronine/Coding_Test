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
        public string Category;
        public string UnitPrice;
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

        Console.WriteLine($"digitOddEvens = [ ");
        foreach (var number in digitOddEvens)
        {
            Console.WriteLine($"        [ Digit : {number.Digit}, Even : {number.Even} ]");
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
                            select new { Digit = strings[n], Even = (n % 2 == 0) }; // 기존의 익명 형식  
                                                                                    //select(Digit: strings[n], Even: (n % 2 ==0));   // C# 7.0 튜플 형식
        Console.WriteLine($"digitOddEvens = [ ");
        foreach (var number in digitOddEvens)
        {
            Console.WriteLine($"        [ Digit : {number.Digit}, Even : {number.Even} ]");
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

    // 속성 집합으로 출력 생성하기
    // Product 객체의 속성 중 ProductName, Category, UnitPrice 속성으로 출력 시퀀스를 만듭니다. 특히 UnitPrice 속성을 Price로 이름을 변경하여 출력 시퀀스를 만들 수도 있습니다.

    public static void SelectProductField()
    {
        List<Product> products = new List<Product>() {
                new Product(){ProductName="상자",ProductID= "1", Category="네모",UnitPrice="1"},
                new Product(){ProductName="모니터",ProductID= "2",Category="네모",UnitPrice="10"},
                new Product(){ProductName="컴퓨터",ProductID= "3",Category="네모",UnitPrice="100"},
                new Product(){ProductName="시계",ProductID= "4",Category="동그라미",UnitPrice="20"},
                new Product(){ProductName="가방",ProductID= "5",Category="동그라미",UnitPrice="40"},
            };

        var productInfos = from p in products
                           select (p.ProductName, p.Category, Price: p.UnitPrice);

        Console.WriteLine($"productInfos = [ ");
        foreach (var product in productInfos)
        {
            Console.WriteLine($"        [ ProductName : {product.ProductName}, Category : {product.Category}, Price : {product.Price} ]");
        }
        Console.WriteLine(" ] ");

        /*출력
        productInfos = [ 
            [ ProductName : 상자, Category : 네모, Price : 1 ]
            [ ProductName : 모니터, Category : 네모, Price : 10 ]
            [ ProductName : 컴퓨터, Category : 네모, Price : 100 ]
            [ ProductName : 시계, Category : 동그라미, Price : 20 ]
            [ ProductName : 가방, Category : 동그라미, Price : 40 ]
        ]   
        */
    }

    // 인덱스를 활용해 출력 만들기
    // numbers 배열의 속성 중 하나인 index 속성을 Select 절에 활용하여 숫자가 자신의 순서에 맞는 위치에 있는지를 확인할 수 있는 출력 시퀀스를 만듭니다.

    public static void PrintIndex()
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        var numsInPlace = numbers.Select((num, index) => (Num: num, InPlace: (num == index)));

        Console.WriteLine($"numsInPlace = [ ");
        foreach (var number in numsInPlace)
        {
            Console.WriteLine($"     [ Num : {number.Num}, InPlace : {number.InPlace}]");
        }
        Console.WriteLine(" ] ");

        /*출력
        numsInPlace = [ 
            [ Num : 5, InPlace : False]
            [ Num : 4, InPlace : False]
            [ Num : 1, InPlace : False]
            [ Num : 3, InPlace : True]
            [ Num : 9, InPlace : False]
            [ Num : 8, InPlace : False]
            [ Num : 6, InPlace : True]
            [ Num : 7, InPlace : True]
            [ Num : 2, InPlace : False]
            [ Num : 0, InPlace : False]
        ] 
        */
    }

    // Select 절과 Where 절을 같이 활용하기
    // Select 절과 Where 절을 활용해서 5이하의 숫자만 출력하는 시퀀스를 만듭니다.

    public static void SelectWhere()
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        var lowNums = from n in numbers
                      where n < 5
                      select digits[n];

        Console.Write($"lowNums = [ ");
        foreach (var number in lowNums)
        {
            Console.Write($"[ {number} ]");
        }
        Console.WriteLine(" ] ");
    }

    /*출력 
    lowNums = [ [ four ][ one ][ three ][ two ][ zero ] ] 
    */

    //여러 입력 시퀀스로부터 하나의 출력 시퀀스 만들기
    // from 절로 numbersA 배열과 numbersB 배열을 입력 시퀀스로 받아 pairs 라는 하나의 출력 시퀀스를 만들 수 있습니다

    public static void SelectTwoArray()
    {
        int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
        int[] numbersB = { 1, 3, 5, 7, 8 };

        var pairs = from a in numbersA
                    from b in numbersB
                    where a < b
                    select (a, b);

        Console.Write($"pairs = [ ");
        foreach (var pair in pairs)
        {
            Console.Write($" [ {pair.a}, {pair.b} ]");
        }
        Console.WriteLine(" ] ");
    }

    // 서로 연관있는 입력 시퀀스로부터 하나의 출력 시퀀스 만들기
    // customers 리스트와 customers의 속성인 Orders를 입력 시퀀스로 받아, 500 이하인 order 만 모은 출력 시퀀스를 만듭니다.

    public class Customer
    {
        public Customer(int ID, Order[] orders)
        {
            CustomerID = ID;
            this.orders = orders;
        }
        public int CustomerID;
        public string Region;
        public Order[] orders;
    }
    public struct Order
    {
        public int OrderID;
        public int Total;
        public DateTime OrderDate;
    }


    public static void SortingToOrder()
    {
        List<Customer> customers = new List<Customer>();

        var orders = from c in customers
                     from o in c.orders
                     where o.Total < 500.50M
                     select (c.CustomerID, o.OrderID, o.Total);

        var Currentorders = from c in customers
                            from o in c.orders
                            where o.OrderDate >= DateTime.Today
                            select (c.CustomerID, o.OrderID, o.OrderDate);

        DateTime cutOffDate = new DateTime(1997, 1, 1);

        var cutOffDateOrders = from c in customers
                               where c.Region == "WA"
                               from o in c.orders
                               where o.OrderDate >= cutOffDate
                               select (c.CustomerID, o.OrderID);
    }

    // SelectMany 절
    public static void SelectMany()
    {
        List<Customer> customers = new List<Customer>();

        var customerOrders = customers.SelectMany(
                                (cust, custIndex) =>
                                cust.orders.Select(o => "Customer #" + (custIndex + 1) +
                                                        " has an order with OrderID " + o.OrderID));
    }
}
