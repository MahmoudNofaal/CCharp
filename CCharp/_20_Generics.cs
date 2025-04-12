using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _20_Generics
{
   public static void Ex01()
   {
      ///WHY GENERICS ??
      ///- FLEXIBLE
      ///- REUSABLE
      ///- TYPE-SAFE CODE
      ///
      ///We use generic in collections, classes, interfaces, methods
      /// that works with any data type.
      /// 
      /// * Type Safety: Generics shift type checking to compile time, minimizing the need
      ///   for casting and preventing runtime errors
      /// * Reusablility: generic class like Box<T> can be reused for any type,
      ///   reducing code duplication (DRY)
      /// * Performance: Generics avoid boxing/unboxing
      /// 

      var number = new Box<int>(5);
      var text = new Box<string>("spider");

      Console.WriteLine(number.GetValue());
      Console.WriteLine(text.GetValue());

   }

   public static void Ex02()
   {
      var pair = new Pair<int, string>(1, "One");

      Console.WriteLine(pair.First);
      Console.WriteLine(pair.Second);

   }

   public static void Ex03()
   {
      int maxNumber = MathHelper.Max(5, 10);

      Console.WriteLine(maxNumber);

   }

   public static void Ex04()
   {
      ///C# PROVIDES COLLECTION IN THE System.Collections.Generics
      ///
      var list = new List<int>() { 1, 2, 3, 4, 5, 5 };

      foreach (var item in list)
      {
         Console.Write(item + " ");
      }

      Console.WriteLine();

      var dictionary = new Dictionary<int, string>();

      dictionary.Add(1, "One");
      dictionary.Add(2, "Two");
      dictionary.Add(3, "Three");
      dictionary.Add(4, "Four");
      dictionary.Add(5, "Five");

      Console.WriteLine("Key - Value");
      foreach (var item in dictionary)
      {
         Console.WriteLine($"{item.Key} - {item.Value}");
      }

   }

   public static void Ex05()
   {
      ///Constraints
      ///- LIMITS THE TYPES THAT CAN BE USED WITH GENERIC TYPE OR METHOD
      ///
      ///. where T : class => T must be a reference type
      ///. where T : struct => T must be a value type
      ///. where T : new() => T must have a parameterless ctor
      ///. where T : BaseClass => T must inherit from BaseClass
      ///. where T : Interface => T must implement Interface

   }

   public static void Ex06()
   {
      /// A DELEGATE IN C# IS A TYPE-SAFE FUNCTION POINTER THAT DEFINES A METHOD
      /// SIGNATURE, ALLOWING METHODS TO BE PASSED AS PARAMETERS OR ASSIGNED TO VARIABLES.
      /// 
      /// [COMMON BUILT-IN GENERIC DELEGATES]
      /// 
      /// - Action<T1,T2,..,Tn> :
      /// represents a method that takes 0 to 16 parameters and returns void [VOID]
      /// Action (no input), Action<T1>, Action<T1,T2>,...
      /// 
      /// - Func<T1,T2,...,Tn,TResult> :
      /// represents a method that takes 0 to 16 parameters and returns TResult [TRESULT]
      /// Funct<TResult>, Func<T1,TResult>, Func<T1,T2,TResult>,...
      /// 
      /// - Predicate<T>
      /// represents a method that takes a T and returns a bool, [often used for filtering]
      /// 

      Action<int> printNumber = n => Console.WriteLine($"Number: {n}");

      printNumber(42);

      Console.WriteLine();////////////////////

      Func<string, int> getLength = t => t.Length;

      int length = getLength("Spider");
      Console.WriteLine($"Length: {length}");

      Console.WriteLine();////////////////////

      Predicate<int> isEven = n => n % 2 == 0;

      Console.WriteLine($"Is Even {isEven(8)}");

   }

   ///HOW TO CUSTOMIZE YOU GENERIC DELEGATE
   public delegate T Transformer<T>(T input); // takes T and returns T
   public static void Ex07()
   {
      Transformer<int> sqaure = x => x * x;
      Transformer<string> toUpper = x => x.ToUpper();

      Console.WriteLine($"Square of 4: {sqaure(4)}");
      Console.WriteLine($"Convert to upper of 'spider': {toUpper("spider")}");

   }

   public static void Ex08()
   {
      ///USING GENERIC DELEGATES WITH COLLECTIONS

      var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

      // using Action (returns void)
      numbers.ForEach(x => Console.Write(x + ", "));
      Console.WriteLine();


      // using Func
      var numbers2 = numbers.ConvertAll(n => n * 2);
      Console.WriteLine(string.Join(", ", numbers2));

      // using Predicate
      var number3 = numbers.FindAll(n => n % 2 == 0);
      Console.WriteLine(string.Join(", ", number3));

   }


}

///THE BASIX SYNTAX FOR GENERICS
class Box<T>
{
   private T _value;

   public Box(T value)
   {
      _value = value;
   }

   public T GetValue()
   {
      return _value;
   }
}

///GENERIC CLASS CAN HAVE ONE OR MORE TYPE PARAMETERS
class Pair<T, U>
{
   public T First { get; set; }
   public U Second { get; set; }

   public Pair(T first, U second)
   {
      this.First = first;
      this.Second = second;
   }

}

///METHODS CAN BE GENERICS
public class MathHelper
{
   // IComparable constraint to ensure T can be compared
   public static T Max<T>(T a, T b) where T : IComparable<T>
   {
      return a.CompareTo(b) > 0 ? a : b;
   }

}


