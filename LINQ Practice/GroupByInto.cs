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
  public static void GetSameFirstLetter()
  {
    string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };

    var wordGroups = from word in words
                     group word by word[0] into g
                     select (FirstLetter: g.Key, Words: g);

    foreach (var word in wordGroups)
    {
      Console.Write($"{word.FirstLetter} : [ "); // 위에서 선언한 Remainder 프로퍼티와 
      foreach (var w in word.Words)          // Numbers 값에 접근이 가능하다
        Console.Write($" {w} ");
      Console.WriteLine(" ] ");
    }
    Console.WriteLine();

    /* 실행결과 
      b:[blueberry  banana]
      c:[chimpanzee  cheese]
      a:[abacus  apple]
    */


    Console.WriteLine();

    /* 실행결과 
      0 : [  5  0  ] 
      4 : [  4  9  ]
      1 : [  1  6  ]
      3 : [  3  8  ]
      2 : [  7  2  ]

    */
  }
  public class Product
  {
    public Product(string category, string name)
    {
      Category = category;
      Name = name;
    }
    public string Category;
    public string Name;
  }
  public static void GetSameCategory()
  {
    List<Product> products = new List<Product>()
    {
        new Product("book","YoungPrice"),
        new Product("fruit","Banana"),
        new Product("fruit","Apple"),
        new Product("book","HarryPorter"),
        new Product("fruit","Grape"),
     };

    var orderGroups = from product in products
                      group product by product.Category into g
                      select (Category: g.Key, Products: g);

    foreach (var product in orderGroups)
    {
      Console.Write($"{product.Category} : [ ");
      foreach (var p in product.Products)
        Console.Write($" {p.Name} ");
      Console.WriteLine(" ] ");
    }
    Console.WriteLine();

    /* 실행결과
      book:[YoungPrice  HarryPorter]
      fruit:[Banana  Apple  Grape]
    */
  }
  #region class AnagramEqulityComparer : IEqualityComparer<T> 
  public class AnagramEqualityComparer : IEqualityComparer<string>
  {
    // 오름차순으로 정렬한 값이 같으면 true
    public bool Equals(string x, string y) => getCanonicalString(x) == getCanonicalString(y);
    public int GetHashCode(string obj) => getCanonicalString(obj).GetHashCode();

    // 문자열이 들어오면 오름차순으로 정렬한다.
    private string getCanonicalString(string word)
    {
      char[] wordChars = word.ToCharArray();
      Array.Sort<char>(wordChars);
      return new string(wordChars);
    }
  }
  #endregion

  // IEqualityComparer<T> 구현하여 그룹화하기
  public static void GetIEqualityComparer()
  {
    string[] anagrams = { "from", "salt", "earn", "last", "near", "form" };

    // IEnumerable<string>.GroupBy<string, string>(Func<string, string> keySelector, IEqualityComparer<string>? comparer)
    // Trim 으로 앞뒤 공백을 제거한다. 왜냐하면 IEqualityComparer<T>를 구현한 AnagramEqulityComparer에는 빈 문자열을 비교하는 로직을 구현 안했기 때문
    // GroupBy를 통해 Trim()된 문자열들이 비교된후에 같은 그룹으로 묶임.
    var orderGroups = anagrams.GroupBy(w => w.Trim(), new AnagramEqualityComparer());

    foreach (var product in orderGroups)
    {
      Console.Write($"{product.Key} : [ ");
      foreach (var p in product.Select(p => p))
        Console.Write($" {p} ");
      Console.WriteLine(" ] ");
    }
    Console.WriteLine();
  }
}



