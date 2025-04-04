using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _8_Constructor
{
   public static void Ex01()
   {
      Date d = new Date();

      d.SetDate(01, 01, 0001);

      Console.WriteLine(d.GetDate());
   }

   public static void Ex02()
   {
      Date d = new Date(01, 01, 0001);

      Console.WriteLine(d.GetDate());
   }

}

public class Date
{
   public int Day;
   public int Month;
   public int Year;

   public Date()
   {
      
   }

   public Date(int day, int month, int year)
   {
      this.Day = day;
      this.Month = month;
      this.Year = year;
   }

   public void SetDate(int day, int month, int year)
   {
      this.Day = day;
      this.Month = month;
      this.Year = year;
   }
   public string GetDate()
   {
      return $"{Day}/{Month}/{Year}";
   }
}

