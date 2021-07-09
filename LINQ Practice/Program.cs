using System;
using System.Reflection;

namespace LINQ_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Where

            // Where.FindLowNums();
            // Where.FilterProducts();
            // Where.FilterCustomerRegionList();
            // Where.FilterToIndex();

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

            // Group By Into 

            // GroupByInto.GetSameRemainder();
            // GroupByInto.GetSameFirstLetter();
            // GroupByInto.GetSameCategory();
            // GroupByInto.GetIEqualityComparer();

            // Partition Operator

            // PartitionOperator.TakeNumber();
            // PartitionOperator.Take3OrdersFromSamePlace();
            // PartitionOperator.Skip4Numbers();
            // PartitionOperator.GetUntil2Orders();
            // PartitionOperator.TakeFirstNumbersLessThan6();
            // PartitionOperator.TakeFirstSmallNumbers();
            // PartitionOperator.SkipWhile();

            // Ordering Operator

            // OrderingOperator.SortedWords();
            // OrderingOperator.SortedWordsByLength();
            // OrderingOperator.SortedProductByName();
            // OrderingOperator.DescendingOrder();
            // OrderingOperator.Sorted2Condition();
            // OrderingOperator.ReversedDigit();
            // OrderingOperator.SortedWordsByComparer();
            // OrderingOperator.SortedWordsByNestedComparer();

            // Set Operators

            // SetOperators.RemoveOverlap();
            // SetOperators.UnionNumbers();
            // SetOperators.IntersectNumbers();
            // SetOperators.ExceptNumbers();

            // Conversion Operator

            // ConversionOperators.ToArray();
            // ConversionOperators.ToList();
            // ConversionOperators.ToDictionary();
            // ConversionOperators.OfType();

            // Element Operators

            // ElementOperators.GetFirstProduct();
            // ElementOperators.FindStartsWithO();
            // ElementOperators.FindNumerOrDefault();
            // ElementOperators.FindProductOrDefault();
            // ElementOperators.FindFourthLowNumber();

            // Range Repeat

            //   RangeRepeat.Range();
            //   RangeRepeat.Repeat();

            // Quantifiers

            // Quantifiers.isElementHere();
            // Quantifiers.isOnlyOdd();
            // Quantifiers.isGroupHaveStock();

            // Aggregators

            //Count
            // Aggregators.Count.DistinctCount();
            // Aggregators.Count.GetOddNumbersCount();
            // Aggregators.Count.CountOrder();

            //Sum
            // Aggregators.Sum.SumNumbers();
            // Aggregators.Sum.SumLength();
            // Aggregators.Sum.SumInproduct();

            //Min
            // Aggregators.Min.GetMin();
            // Aggregators.Min.GetShortestWord();
            // Aggregators.Min.GetSameCategory();

            // SequenceOperations

            SequenceOperations.isMatch();
            SequenceOperations.ConcatNumbers();
            SequenceOperations.GetDotProduct();
        }
    }
}
