using System.Linq;

public class RemoveSmallestNumber
{
  public static int[] solution(int[] arr)
  {
    if (arr.Length == 1) return new int[] { 1 };
    var min = arr.Min();
    return arr.Where(item => item > min).ToArray();
  }
}