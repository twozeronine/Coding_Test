using System;
using System.Linq;

class year2016
{
  enum days2016 { FRI = 1, SAT, SUN, MON, TUE, WED, THU = 0, }

  public static string solution(int month, int day)
  {
    string answer = "";
    int totaldays = day;
    var year2016 = new { months = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 } };
    for (int i = 0; i < month - 1; i++)
    {
      totaldays += year2016.months[i];
    }
    answer = (totaldays % 7) switch
    {
      (int)days2016.MON => "MON",
      (int)days2016.TUE => "TUE",
      (int)days2016.WED => "WED",
      (int)days2016.THU => "THU",
      (int)days2016.FRI => "FRI",
      (int)days2016.SAT => "SAT",
      (int)days2016.SUN => "SUN",
      _ => ""
    };
    return answer;
  }


  // 다른사람의 풀이
  public static string other_solution(int a, int b)
  {
    string answer = "";

    DateTime dateValue = new DateTime(2016, a, b);
    answer = dateValue.ToString();                                      //2016-09-14 오전 12:00:00
    answer = dateValue.DayOfWeek.ToString();                            //Wednesday
    answer = dateValue.DayOfWeek.ToString().Substring(0, 3);            //Wed
    answer = dateValue.DayOfWeek.ToString().Substring(0, 3).ToUpper();  //WED
    return answer;
  }
}
