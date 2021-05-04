using System;

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


    #region Name

    #endregion















  }
}