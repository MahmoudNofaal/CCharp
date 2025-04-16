using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _35_StringBuilder
{

   public static void Ex01()
   {
      ///STRING-BUILDER
      ///It is a mutuable class, designed for efficient string manipulation
      ///* Unlike string type, which creates new object for every
      ///  modification (concatenation), StringBuilder modifies its internal buffer
      ///  in place, reducing memory allocations and improving performance.
      ///  
      ///WHY STRINGBUILDER ?
      ///- Performance
      ///- Efficienty
      ///- Flexibility
      ///- UseCases: Generating Reports, builing JSON manually, logging
      ///
      
      var sb = new StringBuilder();

      sb.Append("Hello, ");
      sb.Append("world!");
      sb.AppendLine(); // Newline
      sb.Append("C# is funny.");

      Console.WriteLine(sb);

   }

   public static void Ex02()
   {
      // Using string (inefficient)
      string str = "";
      for (int i = 0; i < 1000; i++)
      {
         str += i.ToString(); // Creates new string each time
      }

      // Using StringBuilder (efficient)
      var sb = new StringBuilder();
      for (int i = 0; i < 1000; i++)
      {
         sb.Append(i); // Modifies buffer
      }
      string result = sb.ToString();

      Console.WriteLine($"Length: {result.Length}");

   }

   public static void Ex03()
   {
     var names = new List<string> { "Ahmed", "Marwa", "Omar" };

      var sb = new StringBuilder();
      sb.Append("Users: ");

      foreach (string name in names)
      {
         sb.Append(name).Append(", ");
      }

      // Remove trailing comma
      if (names.Count > 0)
      {
         sb.Length -= 2; // Remove ", "
      }

      Console.WriteLine(sb.ToString());
   }

   public static void Ex04()
   {
      var sb = new StringBuilder(1000);

      for (int i = 0; i < 500; i++)
      {
         sb.Append("x");
      }

      Console.WriteLine($"Length: {sb.Length}, Capacity: {sb.Capacity}");

      var sb2 = new StringBuilder("Hello, world!");

      sb2.Insert(7, "beautiful ");
      // Hello, beautiful world!

      sb2.Replace("world", "C#");
      // Hello, beautiful C#!

      // Remove
      sb2.Remove(5, 11); // Remove ", beautiful"
                        // Now: "Hello C#!"

      Console.WriteLine(sb2.ToString()); // Output: Hello C#!

   }

   public static void Ex05()
   {
      StringBuilder sb = new StringBuilder();
      try
      {
         sb.Insert(-1, "text"); // Invalid index
      }
      catch (ArgumentOutOfRangeException ex)
      {
         Console.WriteLine($"Error: {ex.Message}");
      }
   }

}

