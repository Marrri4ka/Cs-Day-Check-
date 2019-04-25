using System;
using System.Collections.Generic;

namespace Year.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine ("Please enter year");
      int userYear = int.Parse(Console.ReadLine());
      Console.WriteLine ("Please enter month");
      int userMonth = int.Parse(Console.ReadLine());
      Console.WriteLine ("Please enter date");
      int userDate = int.Parse(Console.ReadLine());


      MyDate newDateTime = new MyDate (userYear,userMonth,userDate);
      string result = newDateTime.GetDay().ToString();
      Console.WriteLine ("It was :" + result);
    }
  }
}
