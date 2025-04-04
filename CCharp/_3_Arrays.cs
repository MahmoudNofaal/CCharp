using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _3_Arrays
{
   public static void Ex01()
   {
      // Single Dimension Array.
      // - Declaration
      string[] friends = new string[5];

      // - Access elements
      friends[0] = "Ahmed";
      friends[1] = "Khaled";
      friends[2] = "Ali";
      friends[3] = "Omar";

      friends.Print();

      // - Initialization
      var friends2 = new string[]
      {
         "Ahmed",
         "Khaled",
         "Ali",
         "Omar",
      };

      friends2.Print();

   }

   public static void Ex02()
   {
      /// Multi Dimension Array
      /// 
      int[,] suduko =
      {
         {9,5,5,4,1,2 },
         {2,5,4,4,1,2 },
         {9,44,5,6,1,95 },
         {9,8,5,0,1,2 },
      };

   }

   public static void Ex03()
   {
      /// Jagged Array (array inside array)
      /// 
      var jagged = new int[][]
      {
         new int[] { 1,2,3},
         new int[] { 5, 4},
         new int[] { 99,8,7}
      };

      for (int i = 0; i < jagged.Length; i++)
      {
         Console.Write("{ ");
         for (int j = 0; j < jagged[i].Length; j++)
         {
            Console.Write($"{jagged[i][j]}, ");
         }
         Console.Write(" }");
         Console.WriteLine();
      }

   }

   public static void Ex04()
   {
      // Indices and ranges
      var friends = new string[] { "Ahmed", "Khaled", "Ali", "Omar" };

      var first = friends[0];
      /// IF YOU TRY TO USE A NUMBER OUT OF SIZE OF ARRAY YOU'LL GET AN EXCEPTION
      Console.WriteLine($"First: {first}");


      var slice1 = friends[2..];
      Console.WriteLine("Slice1");
      slice1.Print();

      var slice2 = friends[..2];
      Console.WriteLine("Slice2");
      slice2.Print();
      
      var slice3 = friends[1..3];
      Console.WriteLine("Slice3");
      slice3.Print();


   }

}

public static class Extensions
{
   public static void Print<T>(this T[] source)
   {
      if (!source.Any())
      {
         Console.WriteLine("{}");
         return;
      }


      Console.Write("{ ");
      for (int i = 0; i < source.Length - 1; i++)
      {
         Console.Write($"{source[i]}");
         Console.Write(i < source.Length - 1 ? ", " : " ");
      }
      Console.WriteLine(" }");
   }
}

