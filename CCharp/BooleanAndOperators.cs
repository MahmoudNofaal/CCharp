using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class BooleanAndOperators
{

   public static void Ex01()
   {
      bool isTrue = true;

      var x = 10;
      var y = 10;
      Console.WriteLine(x == y);

   }

   public static void Ex02()
   {
      var total = 1000;
      var vipThreshold = 900;

      var isVip = total >= vipThreshold; // >=, <=, ==, !=, >, <

      Console.WriteLine(isVip);

   }


   public static void Ex03()
   {
      // Logical Operators

      //Console.WriteLine(true && true);
      //Console.WriteLine(true || false);

      var isFirstFive = true;
      var GPA = 3.5;

      var isElegibleForScholarship = GPA >= 3.5 || isFirstFive;

      Console.WriteLine(isElegibleForScholarship);

   }

   public static void Ex04()
   {
      // == with reference type  

      var x = 10;
      var y = 10;

      // comparasion with values (value type)
      var z = x == y;

      Console.WriteLine($"value type: {z}");

      var s1 = "word";
      var s2 = "word";

      // comparasion with references (reference type)
      var s3 = s1 == s2;

      Console.WriteLine($"reference type: {s3}");

   }

   public static void Ex05()
   {
      var total = 1000;
      var vipThreshold = 900;


      var isVip = total >= vipThreshold ? true : false; 

      Console.WriteLine(isVip);

   }

}
