using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _37_NULLs
{

   public static void Ex01()
   {
      string name = null; // No string object assigned
      Console.WriteLine(name);

      if (name == null)
      {
         Console.WriteLine("Name is null");
      }

      string text = null;
      ///int length = text.Length; // Throws NullReferenceException
   }

   public static void Ex02()
   {
      int? age = null; // Nullable integer
      Console.WriteLine(age.HasValue); // false

      age = 25;
      Console.WriteLine(age.HasValue); // true
      Console.WriteLine(age.Value);    // 25


      int? score = null;
      int result = score.GetValueOrDefault(100); // Returns 100 if null
      Console.WriteLine(result);

   }

   public static void Ex03()
   {
      string name = null;

      string result = name ?? "Unknown";

      Console.WriteLine(result); // Unknown

      string name2 = null;
      name2 ??= "Ahmed";
      Console.WriteLine(name2); // Ahmed
   }

   public static void Ex04()
   {
      string text = null;

      /// Returns null instead of throwing an exception
      int? length = text?.Length;

      Console.WriteLine(length);
   }

   private static string Greet(string? name)
   {
      if (name == null)
      {
         throw new ArgumentNullException(nameof(name));
      }

      return $"Hello, {name}!";
   }
   public static void Ex05()
   {

      Console.WriteLine(Greet("Ahmed"));

      Console.WriteLine(Greet(null)); // Throws ArgumentNullException
   }


}


