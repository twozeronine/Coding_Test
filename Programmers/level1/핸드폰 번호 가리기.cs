using System.Linq;

public class HidePhoneNumber
{
  public static string solution(string phone_number) => string.Concat(phone_number.Select((e, idx) => e = phone_number.Length - idx > 4 ? '*' : e));
}