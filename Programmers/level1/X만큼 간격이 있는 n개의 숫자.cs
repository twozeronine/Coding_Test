public class IntervalMultiply
{
  public static long[] solution(int x, int n)
  {
    long[] answer = new long[n];
    for (long i = 0; i < n; i++)
    {
      answer[i] = (i + 1) * x;
    }
    return answer;
  }
}