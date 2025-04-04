using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _4_Expressions
{

   public static void Ex01()
   {
      // Primary Expression
      var value = Math.Cos(30) + 1;

      Console.WriteLine(value);

   }

   public static void Ex02()
   {
      // Math Expression

      var x = 5;
      var y = 4;

      Console.WriteLine($"x + y = {x + y}");
      Console.WriteLine($"x - y = {x - y}");
      Console.WriteLine($"x / y = {x / y}");
      Console.WriteLine($"x * y = {x * y}");
      Console.WriteLine($"x % y = {x % y}");

   }

   public static void Ex03()
   {
      // NULL expression
      string s1 = null;

      s1 = s1 ?? "spider"; // this mean if s1 value is null take the value "spider"

      Console.WriteLine(s1);

      s1 = s1 ?? "something else";

      Console.WriteLine(s1);

   }

   public static void Ex04()
   {
      string s1 = null;
      string s2 = "";

      // s1 is not as s2
      // s1 it doesnot exist in the Heap
      // s2 it exist in the Heap and its value is empty

      string s3 = s1?.ToLower(); // null forgiven
      string s4 = s1 is null ? null : s1.ToLower();
      // s3 and s4 do the same job

   }

   public static void Ex05()
   {
      // if Statement

      var mark = 85;
      if (mark >= 60)
      {
         Console.WriteLine("Passed");
      }
      else if (mark >= 55)
      {
         Console.WriteLine("Make up exam chance!");
      }
      else
      {
         Console.WriteLine("Failed");
      }

   }

   public static void Ex06()
   {
      // switch Statement

      var amountEGY = 100;
      var currentType = "USD";
      var output = 0d;

      // EGY -> USD = 0.02, EGY -> EUR = 0.0197, EGY -> CAD = 0.0298
      var EGYtoUSD = 0.02;
      var EGYtoEUR = 0.0197;
      var EGYtoCAD = 0.0298;

      switch (currentType)
      {
         case "USD":
            output = amountEGY * EGYtoUSD;
            Console.WriteLine($"EGY To USD -> Amount : {output}");
            break;
         case "EUR":
            output = amountEGY * EGYtoEUR;
            Console.WriteLine($"EGY To EUR -> Amount : {output}");
            break;
         case "CAD":
            output = amountEGY * EGYtoCAD;
            Console.WriteLine($"EGY To CAD -> Amount : {output}");
            break;
         default:
            output = amountEGY;
            Console.WriteLine($"Amount: {output}, Unknown Currency Type");
            break;
      }

   }

   public static void Ex07()
   {
      // switch

      var num = 3;

      switch (num)
      {
         case 1:
         case 3:
         case 5:
            Console.WriteLine("Odd");
            break;
         case 2:
         case 4:
         case 6:
            Console.WriteLine("Even");
            break;
         default:
            Console.WriteLine("Zero");
            break;
      }

   }

   public static void Ex08()
   {
      // switch

      object o = 3;

      switch (o)
      {
         case int i:
            Console.WriteLine($"It is integer and its sqrt: {Math.Sqrt(i)}");
            break;
         case string i:
            Console.WriteLine($"It is string and its CAPITALIZATION: {i.ToUpper()}");
            break;
      }

   }

   public static void Ex09()
   {
      // switch

      bool isVip = true;

      switch (isVip)
      {
         case bool i when i is true:
            Console.WriteLine("YES");
            break;
         case bool i when i is false:
            Console.WriteLine("FALSE");
            break;
      }

   }

   public static void Ex10()
   {
      // switch

      var cardNo = 13;

      string cardName = cardNo switch
      {
         1 => "ACE",
         13 => "KING",
         23 => "QUEEN",
         10 => "JACK",
         _ => cardNo.ToString()
      };

      Console.WriteLine(cardName);

   }

   public static void Ex11()
   {
      // Iterations

      var counter = 0;

      while (counter < 10)
      {
         Console.WriteLine(counter);
         counter++;
      }

   }

   public static void Ex12()
   {
      // Iterations

      var counter = 0;

      do
      {
         Console.WriteLine(counter);
         counter++;
      } while (counter < 10);

   }

   public static void Ex13()
   {
      // iteration 

      for (int i = 0; i < 10; i++)
      {
         Console.WriteLine(i);
      }
   }

   public static void Ex14()
   {
      // iteration 

      var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

      foreach (var i in arr)
      {
         Console.WriteLine(i);
      }
   }

   public static void Ex15()
   {
      // iteration

      // fibonacci (0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55)

      for(int counter=0, prev = 0, current =1; counter<11; counter++)
      {
         Console.Write($"{prev} ");
         int newItem = prev + current;

         prev = current;
         current = newItem;
      }

   }

   public static void Ex16()
   {
      // Jump [break, continue, goto, return]

      int i = 0;

      while(i < 10)
      {
         if(i > 5)
            break;

         Console.WriteLine(i);
         i++;
      }

   }

   public static void Ex17()
   {
      // Jump [break, continue, goto, return]

      for(int i=0; i<10; i++)
      {
         if (i % 2 == 0)
            continue;

         Console.WriteLine(i);
      }

   }

}
