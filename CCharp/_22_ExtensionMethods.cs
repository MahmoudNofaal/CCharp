using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _22_ExtensionMethods
{
   public static void Ex01()
   {
      ///IN C# ALLOW YOU TO "extend" EXISTING TYPES (classes, interfaces, structs,..)
      ///BY ADDING NEW METHODS TO THEM WITHOUT MODIFYING THEIR SOURCE CODE OR CREATED 
      ///DERIVED CLASSES.
      ///- they r static methods in static class, but you can call them as if there
      ///  were instaces
      ///  

      string email = "user1@example.com";

      if(email.IsValidEmail())
      {
         Console.WriteLine($"It is valid email");
      }
      else
      {
         Console.WriteLine($"It is not valid email");
      }

   }

   public static void Ex02()
   {
      double[] values = { 1.5, 3.2, 4.5, 7.8 };

      Console.WriteLine($"Median: {values.Median()}");

   }

}

static class StringExtensions
{
   public static bool IsValidEmail(this string email)
   {
      if(string.IsNullOrEmpty(email))
         return false;
      return email.Contains('@') && email.Contains('.');
   }
}

static class EnumerableExtensions
{
   public static double Median(this IEnumerable<double> numbers)
   {
      if (numbers is null || !numbers.Any())
         throw new ArgumentException("Collection cannot be empty or null!");

      var sorted = numbers.OrderBy(n => n).ToList();

      int count = sorted.Count;
      if (count % 2 == 0)
         return (sorted[count / 2 - 1] + sorted[count / 2]) / 2;
      
      return sorted[count / 2];
   }
}

