using System;
using System.Linq;
using System.Collections.Generic;

public class GroupByInto
{
  public static void GetSameRemainder()
  {
    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

    var numberGroups = from number in numbers // numbers 배열에서 number 값을 가져온다
                       group number by number % 5 into numberGroup // number % 5 가 같은 값을 numberGroup에 그룹짓는다.
                       select (Remainder: numberGroup.Key, Numbers: numberGroup); // 그 그룹에서 Remainder 와 Numbers 프로퍼티를 설정한다.

    foreach (var number in numberGroups)
    {
      Console.Write($"{number.Remainder} : [ "); // 위에서 선언한 Remainder 프로퍼티와 
      foreach (var n in number.Numbers)          // Numbers 값에 접근이 가능하다
        Console.Write($" {n} ");
      Console.WriteLine(" ] ");
    }

    /* 출력
    0 : [  5  0  ] 
    4 : [  4  9  ]
    1 : [  1  6  ]
    3 : [  3  8  ]
    2 : [  7  2  ]

    number.Remainder : [ number.Numbers[0] number.Numbers[1] ]
    */
  }
}
