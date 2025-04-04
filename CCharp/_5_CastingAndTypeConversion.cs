using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _5_CastingAndTypeConversion
{

   public static void Ex01()
   {
      Int16 s; // (alias) short s; => 16bit
      Int32 i; // (alias) int s; => 32bit
      Int64 l; // (alias) long l; => 64bit
      UInt16 ush; // (alias) ushort ush; => 16bit

   }

   public static void Ex02()
   {
      /// OUR C# LANGUAGE ARE STRONG TYPED LANGUAGE
      /// AS YOU CANNOT STORE A STRING VALUE IN A NUMERIC VARIABLE AND CONTRA VERSE
      /// AND CANNOT STORE BIG SIZE THAN THE VARIABLE TYPE CAN STORE!!

      var num = 10;
      string str = num.ToString(); // implicit casting

      Console.WriteLine($"str: {str}");

      /////////
      ///
      int numberInt = 100;
      long numberLong = numberInt;

      long nL = 1000;
      int nI = (int)nL; // Implicit Casting

      Console.WriteLine($"nI: {nI}");

      /// YOU CAN USE SAFE WAY
      if(nL <= Int32.MaxValue)
      {
         nI = (int)nL; /// THIS IS SAFE WAY
      }

      ///////////////////////////
      ///
      double d = 1234.5;
      int i = (int)d; // Explicit Casting

      Console.WriteLine($"i: {i}");
   }

   public static void Ex03()
   {
      /// Boxing, Unboxing
      /// 
      int x = 10;
      Object o;

      o = x;
      /// IMPLICIT CASTING

      Console.WriteLine(o);

      int y = (int)o;
      /// EXPLICIT CASTING

      Console.WriteLine(y);

   }

   public static void Ex04()
   {
      string stringValue = "120";
      int number = int.Parse(stringValue); /// IS NOT SAFE!
      Console.WriteLine(number);
      /// THERE IS EXCEPTION WILL BE THROWN IF THE STRING HAS NOT VALUE OF NUMBER ONLY
      /// 
      if(int.TryParse(stringValue, out int n)) /// THE SAFE WAY FROM THROWING AN EXCEPTION
      {
         Console.WriteLine(n);
      }
      else
      {
         Console.WriteLine("Invalid number provided or doesnot fit integer");
      }

   }

   public static void Ex05()
   {
      //BitConvertor

      var number = 255;
      var bits = BitConverter.GetBytes(number); /// RETURNS ARRAY OF BITS OF LENGTH 4

      /// WE CAN PRINT THIS ARRAY
      foreach (var bit in bits)
      {
         Console.Write($"[{bit}] ");

         var binary = Convert.ToString(bit, 2);
         Console.WriteLine($", {bit}");

      }

   }

}

