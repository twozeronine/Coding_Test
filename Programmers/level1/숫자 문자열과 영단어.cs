using System;
using System.Collections.Generic;

public class NumberAndEnglish
{
  public static int solution(string n)
  {
    Dictionary<string, int> wordsMap = new Dictionary<string, int>()
    {
      {"zero",0},
      {"one",1},
      {"two",2},
      {"three",3},
      {"four",4},
      {"five",5},
      {"six",6},
      {"seven",7},
      {"eight",8},
      {"nine",9},
    };

    foreach (var word in wordsMap)
    {
      n = n.Replace(word.Key, word.Value.ToString());
    }
    var result = int.Parse(n);
    return result;
  }
}