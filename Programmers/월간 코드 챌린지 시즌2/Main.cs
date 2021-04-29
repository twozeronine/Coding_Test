using System;

class MainApp
{

  static void Main(string[] args)
  {

    // test 1
    int[] absolutes = new int[3] { 4, 7, 12 };
    bool[] signs = new bool[3] { true, false, true };
    Console.WriteLine(test1.solution(absolutes, signs));

    // test 2
    string case1;
    case1 = "}]()[{";
    Console.WriteLine(test2.solution(case1));
  }
}