using System;
using System.Linq;

class trainingclothes
{
  public static int solution(int n, int[] lost, int[] reserve)
  {
    int getcloth = 0;
    int haveCloth = n - lost.Length;
    int[] StupidStudent = lost.Intersect(reserve).ToArray();
    int[] realLostStudent = lost.Except(StupidStudent).ToArray();
    int[] stillhaveStudent = reserve.Except(StupidStudent).ToArray();
    for (int i = 0; i < stillhaveStudent.Length; i++)
    {
      for (int j = 0; j < realLostStudent.Length; j++)
      {
        if (realLostStudent[j] - 1 == stillhaveStudent[i] || realLostStudent[j] + 1 == stillhaveStudent[i])
        {
          realLostStudent[j] = -1;
          stillhaveStudent[i] = -1;
          getcloth++;
        }
      }
    }
    haveCloth += StupidStudent.Length;
    return getcloth + haveCloth;
  }
}
