public class SumMatrix
{
  public static int[,] solution(int[,] arr1, int[,] arr2)
  {
    var arr = new { Length1 = arr1.GetLength(0), Length2 = arr1.GetLength(1) };
    int[,] answer = new int[arr.Length1, arr.Length2];
    for (int i = 0; i < arr.Length1; i++)
    {
      for (int j = 0; j < arr.Length2; j++)
      {
        answer[i, j] = arr1[i, j] + arr2[i, j];
      }
    }
    return answer;
  }
}