using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _14_Finalizer
{

   public static void Ex01()
   {
      ///WHAT IS THE FINALIZER
      ///- It is a special method in a class that is automatically called by the
      ///  Garbage Collector (GC) when an object is being cleaned up, right before
      ///  the object is removed from memory.
      ///  -----------
      ///WHAT IS CHARACTERISTICS IN CODEING
      ///- IT CANNOT HAVE PARAMETERS
      ///- IT CANNOT BE CALLED MANUALLY
      ///- IT CANNOT BE OVERLOADED LIKE ctor OR INHERITED
      ///

      var p = new Person();
      p.Name = "Ahmed";

      ///DESCTRUCTOR CALLED WHEN THE OBJECT IS OUT OF ITS SCOPE

   }

   public static void Ex02()
   {
      //CALL Method
      MakeSomeGarabge();

      Console.WriteLine($"Memory used before GC {GC.GetTotalMemory(false):N}"); // 99,999,999.00

      GC.Collect();

      Console.WriteLine($"Memory used after GC {GC.GetTotalMemory(false):N}"); // 99,999,999.00


   }

   private static void MakeSomeGarabge()
   {
      Version v;

      for (int i = 0; i < 1000; i++)
      {
         v = new Version();
      }
   }

}

public class Person
{
   public string Name { get; set; }

   public Person()
   {
      Console.WriteLine("This is Person constructor");
   }

   ~Person()
   {
      Console.WriteLine("This is Person desctructor");
   }

}

