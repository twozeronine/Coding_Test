﻿using System;
using System.Reflection;

namespace LINQ_Practice
{
  class Program
  {
    static void Main(string[] args)
    {
      // Where

      Where.FindLowNums();
      Where.FilterProducts();
      Where.FilterCustomerRegionList();
      Where.FilterToIndex();

      // Select

      // Select.PrintSequence();
      // Select.SelectOneField();
      // Select.SwapPrint();
      // Select.SortWordsCase();
      // Select.DigitOddEven();
      // Select.SelectProductField();
      // Select.PrintIndex();
      // Select.SelectWhere();
      // Select.SelectTwoArray();

      // GroupByInto 

      // GroupByInto.GetSameRemainder();
      // GroupByInto.GetSameFirstLetter();
      // GroupByInto.GetSameCategory();
      // GroupByInto.GetIEqualityComparer();
    }
  }
}
