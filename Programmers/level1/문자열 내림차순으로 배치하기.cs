using System;
using System.Linq;

public class StringSort
{
  public static string solution(string s)
  {
    return string.Concat(s.OrderByDescending(c => c));
  }
}

/*char[]를 string으로 변환하는 2가지 방법

char는 struct, string은 class

char[]가 string이 되기 위해서는 배열을 문자열로 변환해주어야함.

1. 생성자를 이용하여 char[]를 string으로 변환하기

char[] characters ={'h','e','l','l','o'};
string str = new string(characters);

2. 메소드를 이용하여 char[]를 string으로 변환하기 

char[] characters ={'h','e','l','l','o'};
string str = string.Join("",characters);

char[] characters ={'h','e','l','l','o'};
string str = string.Concat(characters);

*/
