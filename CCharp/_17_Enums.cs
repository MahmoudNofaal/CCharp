using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _17_Enums
{

   public static void Ex01()
   {
      Console.WriteLine(Month.JAN);

      Console.WriteLine((int) Month.JAN);

   }

   public static void Ex02()
   {
      var day = (Day.SATURDAY | Day.SUNDAY);
      if (day.HasFlag(Day.WEEKEND))
      {
         Console.WriteLine("ENJOY YOUR WEEKEND");
      }

   }

   public static void Ex03()
   {
      var month = "feb";
      if(Enum.TryParse(month.ToUpper(), out Month month1))
      {
         Console.WriteLine(month1);
      }
      else
      {
         Console.WriteLine("Invalid entry");
      }

   }

   public static void Ex04()
   {
      ///LOOPING THROUGH ENUM
      ///
      foreach(var month in Enum.GetValues(typeof(Month)))
      {
         Console.WriteLine($"{month} = {(int)month}");
      }
   }

}

public enum Month
{
   JAN,
   FEB,
   MAR,
   APR,
   JUNE,
   JUL,
   AUG,
   SEP,
   OCT,
   NOV,
   DEC
}

[Flags]
public enum Day
{
   NONE = 0B_0000_0000, // 0,
   MONDAY = 0B_0000_0001, // 1,
   TUESDAY = 0B_0000_0010, // 2,
   WEDNESDAY = 0B_0000_0100, // 4,
   THURSDAY = 0B_0000_1000, // 8,
   FRIDAY = 0B_0001_0000, // 16,
   SATURDAY = 0B_0010_0000, // 32,
   SUNDAY = 0B_0100_0000, // 64,

   BUSYDAY = MONDAY | TUESDAY | WEDNESDAY | THURSDAY | FRIDAY,
   WEEKEND = SATURDAY | SUNDAY,
}

