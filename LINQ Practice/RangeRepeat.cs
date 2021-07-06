using System;
using System.Linq;
using System.Collections.Generic;

public class RangeRepeat
{
  // Range(int start, int count) start 부터 count 만큼 숫자 범위 집합을 생성합니다.
  public static void Range()
  {
    var numbers = from n in Enumerable.Range(100, 50) // 100 - 149 까지
                  select (Number: n, OddEven: n % 2 == 1 ? "odd" : "even");


    Console.Write($"numbers = [ ");
    foreach (var number in numbers)
    {
      Console.Write($" {number} ");
    }
    Console.WriteLine(" ] ");


    /* 출력
    numbers = [  
      (100, even)  (101, odd)  (102, even)  (103, odd)  (104, even)  
      (105, odd)  (106, even)  (107, odd)  (108, even)  (109, odd)  
      (110, even)  (111, odd)  (112, even)  (113, odd)  (114, even)  
      (115, odd)  (116, even)  (117, odd)  (118, even)  (119, odd)  
      (120, even)  (121, odd)  (122, even)  (123, odd)  (124, even)  
      (125, odd)  (126, even)  (127, odd)  (128, even)  (129, odd)  
      (130, even)  (131, odd)  (132, even)  (133, odd)  (134, even)  
      (135, odd)  (136, even)  (137, odd)  (138, even)  (139, odd)  
      (140, even)  (141, odd)  (142, even)  (143, odd)  (144, even)  
      (145, odd)  (146, even)  (147, odd)  (148, even)  (149, odd)  ] 
    */
  }


  // Repeat(int element, int count) element를 count 만큼 반복한 집합을 생성합니다.
  public static void Repeat()
  {
    var numbers = Enumerable.Repeat(7, 10);

    Console.Write($"numbers = [ ");
    foreach (var number in numbers)
    {
      Console.Write($" {number} ");
    }
    Console.WriteLine(" ] ");

    /* 출력 
    numbers = [  7  7  7  7  7  7  7  7  7  7  ] 
    */
  }
}