using System;

/*실행 결과 

모의고사 정답 : 123
K번째수 정답 : 563
체육복 정답 :5
2016년 정답 : WED
가운데 글자 가져오기 정답 : a
소수 만들기 정답 : 84
로또의 최고 순위와 최저 순위 : [4, 6]
예산: 3
3진법 뒤집기 : 7
내적 : 3
두 개 뽑아서 더하기 : 234567
두 정수 사이의 합 : 50000005000000
문자열 내 마음대로 정렬하기 : abzaa,abzbb,abzcd,bbzaa,cdzab
문자열 내림차순으로 배치하기 : gfedcbZ
문자열 다루기 기본 : False
서울에서 김서방 찾기 : 김서방은 1에 있다
n까지의 소수의 갯수는 ? : 8
수박수박수박수박수박수박수박수박수박수박수박수박수박수박수박
문자열을 정수로 바꾸기 : 1234
시저 암호 : D G d F aF
약수의 합 : 28
이상한 문자 만들기 : TrY HeLlO WoRlD
자릿수 더하기 : 32
자연수 뒤집어 배열로 만들기 : 432536797
정수 내림차순으로 배치하기 : 977654332
정수 제곱근 판별 : -1
제일 작은 수 제거하기 :  432
짝수와 홀수 : Odd
최대공약수와 최소공배수 :  3 12
콜라츠 추측 : 4
평균 구하기 : 2.5
하샤드 수 : True
핸드폰 번호 가리기 : *******4444
행렬의 덧셈 :  4 6 7 9
X만큼 간격이 있는 n개의 숫자 :  2 4 6 8 10
*/

class MainApp
{
    static void Main(string[] args)
    {
        #region 모의고사

        // 모의고사

        int[] a = { 1, 3, 2, 4, 2 };
        var result = test.solution(a);
        Console.Write("모의고사 정답 : ");
        foreach (var student in result)
        {
            Console.Write(student);
        }

        Console.WriteLine();
        #endregion

        #region K번째수

        // K번째수 

        int[] array = { 1, 5, 2, 6, 3, 7, 4 };
        int[,] commands = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };
        var result2 = Knumber.solution8(array, commands);
        Console.Write("K번째수 정답 : ");
        foreach (var num in result2)
        {
            Console.Write(num);
        }
        Console.WriteLine();
        #endregion

        #region 체육복
        // 체육복
        int n = 5;
        int[] lost = { 2, 4 };
        int[] reserve = { 1, 3, 5 };
        var result3 = trainingclothes.solution(n, lost, reserve);
        Console.WriteLine($"체육복 정답 :{result3}");
        #endregion

        #region 2016년
        // 2016년
        int month = 9;
        int days = 14;
        var result4 = year2016.solution(month, days);
        result4 = year2016.other_solution(month, days);
        Console.WriteLine($"2016년 정답 : {result4}");

        #endregion

        #region 가운데 글자 가져오기

        //가운데 글자 가져오기
        string words = "a";
        var result5 = MiddleNumber.solution(words);
        Console.WriteLine($"가운데 글자 가져오기 정답 : {result5}");
        #endregion

        #region 소수 만들기
        //소수 만들기
        int[] nums = { 1, 2, 3, 4, 7, 8, 13, 15, 36, 24, 12, 56, 37, 67 };
        var result6 = PrimeNumeber.solution(nums);
        Console.WriteLine($"소수 만들기 정답 : {result6}");
        #endregion

        #region 로또의 최고 순위와 최저 순위


        //로또의 최고 순위와 최저 순위
        int[] lottos = new int[6] { 44, 1, 0, 0, 31, 25 };
        int[] win_nums = new int[6] { 38, 19, 20, 40, 15, 25 };
        var result7 = lotto.solution(lottos, win_nums);
        Console.WriteLine($"로또의 최고 순위와 최저 순위 : [{result7[0]}, {result7[1]}]");
        #endregion

        #region 예산
        //예산
        int[] d = new int[5] { 1, 3, 2, 5, 4 };
        int budget = 9;
        var result8 = Money.solution(d, budget);
        Console.WriteLine($"예산: {result8}");
        #endregion

        #region 3진법 뒤집기

        //3진법 뒤집기
        int num10 = 45;
        var result9 = TernaryReverse.solution(num10);
        Console.WriteLine($"3진법 뒤집기 : {result9}");
        #endregion

        #region 내적 구하기

        // 내적 구하기
        int[] vector1 = { 1, 2, 3, 4 };
        int[] vector2 = { -3, -1, 0, 2 };
        var result10 = DotProduct.solution(vector1, vector2);
        Console.WriteLine($"내적 : {result10}");
        #endregion

        #region 두 개 뽑아서 더하기

        // 두 개 뽑아서 더하기
        int[] numbers = { 2, 1, 3, 4, 1 };
        var result11 = PickTwoSum.solution(numbers);
        Console.Write($"두 개 뽑아서 더하기 : ");
        foreach (var num in result11)
        {
            Console.Write(num);
        }
        Console.WriteLine();
        #endregion

        #region 나누어 떨어지는 숫자 배열
        //나누어 떨어지는 숫자 배열
        int[] arr = { 5, 9, 7, 10 };
        int divisor = 5;
        var result12 = Divisor.solution(arr, divisor);
        #endregion

        #region 두 정수 사이의 합
        //두 정수 사이의 합
        var result13 = integer.solution(0, 10000000);
        Console.WriteLine($"두 정수 사이의 합 : {result13}");
        #endregion

        #region 문자열 내 마음대로 정렬하기
        //문자열 내 마음대로 정렬하기
        string[] strings = { "abzaa,abzbb,abzcd,bbzaa,cdzab" };
        var result14 = PickString.solution(strings, 2);
        Console.Write("문자열 내 마음대로 정렬하기 : ");
        foreach (var item in result14)
        {
            Console.Write(item);
        }
        Console.WriteLine();

        #endregion

        #region 문자열 내림차순으로 배치하기
        //문자열 내림차순으로 배치하기
        string s = "Zbcdefg";
        var result15 = StringSort.solution(s);
        Console.WriteLine($"문자열 내림차순으로 배치하기 : {result15}");
        #endregion

        #region 문자열 다루기 기본
        //문자열 다루기 기본
        string str = "123a";
        var result16 = StringBasic.solution(str);
        Console.WriteLine($"문자열 다루기 기본 : {result16}");
        #endregion

        #region 서울에서 김서방 찾기

        //서울에서 김서방 찾기
        string[] seoul = { "Jane", "Kim" };
        var result17 = WhereisKim.solution(seoul);
        Console.WriteLine($"서울에서 김서방 찾기 : {result17}");
        #endregion


        #region 소수찾기

        //소수 찾기
        int number = 20;
        var result18 = FindPrimeNumber.solution(number);
        Console.WriteLine($"n까지의 소수의 갯수는 ? : {result18}");


        #endregion

        #region 수박수박수박수박수박수

        //수박수박수박수박수박수
        number = 30;
        var result19 = WaterMelon.solution(number);
        Console.WriteLine($"{result19}");

        #endregion

        #region 문자열을 정수로 바꾸기

        //문자열을 정수로 바꾸기
        s = "1234";
        var result20 = ParseStringtoInt.solution8(s);
        Console.WriteLine($"문자열을 정수로 바꾸기 : {result20}");

        #endregion

        #region 시저 암호 

        //시저 암호
        s = "A D a C xC";
        var result21 = CaesarCipher.solution(s, 3);
        Console.WriteLine($"시저 암호 : {result21}");

        #endregion

        #region 약수의 합 

        //약수의 합
        number = 12;
        var result22 = DivisorSum.solution(number);
        Console.WriteLine($"약수의 합 : {result22}");

        #endregion

        #region 이상한 문자 만들기 

        //이상한 문자 만들기
        s = "try hello world";
        var result23 = MakeStrangeString.solution(s);
        Console.WriteLine($"이상한 문자 만들기 : {result23}");

        #endregion

        #region 자릿수 더하기

        //자릿수 더하기
        number = 797234;
        var result24 = digitsum.solution(number);
        Console.WriteLine($"자릿수 더하기 : {result24}");

        #endregion

        #region 자연수 뒤집어 배열로 만들기

        //자연수 뒤집어 배열로 만들기
        number = 797635234;
        var result25 = Naturalnumber.solution(number);
        Console.Write($"자연수 뒤집어 배열로 만들기 : ");
        foreach (var item in result25)
        {
            Console.Write(item);
        }
        Console.WriteLine();

        #endregion

        #region 정수 내림차순으로 배치하기

        //정수 내림차순으로 배치하기
        number = 797635234;
        var result26 = Sortinteger.solution(number);
        Console.WriteLine($"정수 내림차순으로 배치하기 : {result26} ");

        #endregion

        #region 정수 제곱근 판별

        //정수 제곱근 판별
        number = 797635234;
        var result27 = Squareroot.solution(number);
        Console.WriteLine($"정수 제곱근 판별 : {result27} ");

        #endregion

        #region 제일 작은 수 제거하기

        //제일 작은 수 제거하기
        arr = new int[] { 4, 3, 2, 1 };
        var result28 = RemoveSmallestNumber.solution(arr);
        Console.Write($"제일 작은 수 제거하기 :  ");
        foreach (var item in result28)
        {
            Console.Write(item);
        }
        Console.WriteLine();

        #endregion

        #region 짝수와 홀수

        //짝수와 홀수
        number = 3;
        var result29 = EvenOrOdd.solution(number);
        Console.WriteLine($"짝수와 홀수 : {result29} ");

        #endregion

        #region 최대공약수와 최소공배수

        //최대공약수와 최소공배수
        number = 3;
        n = 12;
        var result30 = GCDLCM.solution(number, n);
        Console.Write($"최대공약수와 최소공배수 :  ");
        foreach (var item in result30)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();

        #endregion

        #region 콜라츠 추측

        //콜라츠 추측
        n = 16;
        var result31 = Collatz.solution(n);
        Console.WriteLine($"콜라츠 추측 : {result31}");

        #endregion

        #region 평균 구하기

        //평균 구하기
        arr = new int[] { 1, 2, 3, 4 };
        var result32 = Average.solution(arr);
        Console.WriteLine($"평균 구하기 : {result32}");

        #endregion

        #region 하샤드 수

        //하샤드 수
        number = 10;
        var result33 = HashadNumber.solution(number);
        Console.WriteLine($"하샤드 수 : {result33}");

        #endregion

        #region 핸드폰 번호 가리기

        //핸드폰 번호 가리기
        s = "01033334444";
        var result34 = HidePhoneNumber.solution(s);
        Console.WriteLine($"핸드폰 번호 가리기 : {result34}");

        #endregion

        #region 행렬의 덧셈

        //행렬의 덧셈
        int[,] arr2 = new int[2, 2] { { 1, 2 }, { 2, 3 } };
        int[,] arr3 = new int[2, 2] { { 3, 4 }, { 5, 6 } };
        var result35 = SumMatrix.solution(arr2, arr3);
        Console.Write($"행렬의 덧셈 :  ");
        foreach (var item in result35)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();

        #endregion

        #region X만큼 간격이 있는 n개의 숫자

        //X만큼 간격이 있는 n개의 숫자
        n = 5;
        number = 2;
        var result36 = IntervalMultiply.solution(number, n);
        Console.Write($"X만큼 간격이 있는 n개의 숫자 :  ");
        foreach (var item in result36)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();

        #endregion

        #region 부족한 금액 계산하기

        //부족한 금액 계산하기
        var price = 3;
        var money = 20;
        var count = 4;
        var result37 = GetlessPrice.solution(price, money, count);
        Console.Write($"부족한 금액 :  ");
        Console.Write($"{result37} ");
        Console.WriteLine();

        #endregion
        #region 숫자 문자열과 영단어

        //숫자 문자열과 영단어
        var insert = "one4seveneight";
        var result38 = NumberAndEnglish.solution(insert);
        Console.Write($"숫자 문자열과 영단어 :  ");
        Console.WriteLine(result38);

        #endregion


    }
}