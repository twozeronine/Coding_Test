public class GCDLCM
{
  public static int[] solution(int n, int m)
  {
    int LCM = 0, GDC = 0;
    int greater = n > m ? n : m;
    int smaller = n > m ? m : n;
    int R = greater % smaller;
    int temp = 0;
    while (R != 0)
    {
      temp = smaller % R;
      smaller = R;
      R = temp;
    }
    GDC = smaller;
    LCM = (n * m) / GDC;
    int[] answer = new int[] { GDC, LCM };
    return answer;
  }
}