using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _1_Variables
{

   public static void Ex01()
   {
      // declare a variable
      int num; // memory reserved in [stack]

      // assign the variable
      num = 5;

      // initialization
      int num02 = 6;

      /// Value Type (who reserved in the Stack)
      /// int, float, double, bool, char, byte, short, long, decimal
      /// enum, struct

      /// Reference Type (who reserved in the Heap)
      /// string, class, interface, array, delegate

      /// DIFFERENCE :
      /// The difference between (Value Type) & (Reference Type)
      ///- Limitation: the value type has a limit (fixed) size,
      ///  reference type has a grow dynamically size.

      // string is the reference type
      // Nothing is reserved in the heap (as it doesnot initialized yet.)
      string str;

      str = "spider";

      string s02 = "x";

      // CONCATENATION
      // Regular concatenation (plus + sign)
      string s03 = str + " " + s02;

      // String Interpolation
      string s04 = $"{str} {s02}";

      Console.WriteLine(s04);

      Console.WriteLine();
   }

   public static void Ex02()
   {
      /// Limit size for each value type
      /// 
      Console.WriteLine($"sbyt : {sbyte.MinValue} -> {sbyte.MaxValue}");
      Console.WriteLine($"byte : {byte.MinValue} -> {byte.MaxValue}");
      Console.WriteLine($"short : {short.MinValue} -> {short.MaxValue}");
      Console.WriteLine($"ushort : {ushort.MinValue} -> {ushort.MaxValue}");
      Console.WriteLine($"int : {int.MinValue} -> {int.MaxValue}");
      Console.WriteLine($"uint : {uint.MinValue} -> {uint.MaxValue}");
      Console.WriteLine($"long : {long.MinValue} -> {long.MaxValue}");
      Console.WriteLine($"ulong : {ulong.MinValue} -> {ulong.MaxValue}");
      Console.WriteLine($"float : {float.MinValue} -> {float.MaxValue}");
      Console.WriteLine($"double : {double.MinValue} -> {double.MaxValue}");
      Console.WriteLine($"decimal : {decimal.MinValue} -> {decimal.MaxValue}");

   }

   public static void Ex03()
   {
      /// var Keyword
      ///The compiler determine the type at compile time
      ///Cannot change the type as you assigned it before
      ///
      var s1 = "spider"; // determined as a string

      var f1 = 0f; // determined as a float
      var d1 = 0d; // determined as a double
      var de1 = 0m; // determined as a decimal (Money)
      var l1 = 0l; // determined as a long
      var u1 = 0u; // determined as a uint

      // can use discard
      var oneMillon = 1_000_000;


      /// dynamic Keyword
      /// The type are determine at runtime 
      /// which me you can initialized it with a type and assigned it again with another type
      /// 
      dynamic x = 5;

      x = "spider";

      x = 10m;

   }


}
