using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _36_Tuples
{

   public static void Ex01()
   {
      ///TUPLES
      ///* It is a data structure that allows you to group multiple elements of different
      ///  types into a single object.
      ///  
      ///WHY TUPLES ?
      ///- Lightweight
      ///- Flexible Size: supports 1 to 8 elements natively

      var tuple = (42, "Hello");

      // Access elements using Item1, Item2,...
      Console.WriteLine($"First: {tuple.Item1}, Second: {tuple.Item2}");
   }

   public static void Ex02()
   {
      // Named tuple
      var person = (name: "Ahmed", age: 30);

      // Accessing elements by name
      Console.WriteLine($"Name: {person.name}, Age: {person.age}");

   }


   public static void Ex03()
   {
      string name = "Ali";
      int age = 25;
      var person = (name, age); // Names are inferred as 'name' and 'age'

      Console.WriteLine($"Name: {person.name}, Age: {person.age}");


      (string name, int age) person2 = ("Omar", 35);
      Console.WriteLine($"Name: {person2.name}, Age: {person2.age}");
   }

   private static (string name, int age) GetPerson()
   {
      return ("Marwa", 40);
   }
   public static void Ex04()
   {
      var person = GetPerson();
      Console.WriteLine($"Name: {person.name}, Age: {person.age}");
   }

   private static (int sum, int product) Calculate(int a, int b)
   {
      return (a + b, a * b);
   }
   public static void Ex05()
   {
      var result = Calculate(5, 3);
      Console.WriteLine($"Sum: {result.sum}, Product: {result.product}");
   }


   public static void Ex06()
   {
      var people = new List<(string name, int age)>
      {
         ("Hazem", 31),
         ("Yousef", 26),
         ("Mai", 34)
      };

      foreach (var person in people)
      {
         Console.WriteLine($"Name: {person.name}, Age: {person.age}");
      }
   }


}


