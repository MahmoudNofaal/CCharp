using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _18_Inheritance
{
   public static void Ex01()
   {
      ///INHERITANCE
      ///A technique which let aquire all properties and behaboirs its
      /// parent type automatically.
      /// 
      /// WHY INHERITANCE
      /// - REUSABILITY -قابلةلأعادة الاستخدام-
      /// - MAINTAINABILITY -قابلة للصيانة-
      /// - EXTENSIBILITYVICALLY -قابلة للتمدد-
      /// 
      /// - .NET DOES NOT SUPPORT MULTIPLE INHERITANCE

      var e = new Eagle();

      var a = new Animal();

      a = e;

      a.Move();

   }

}

class Animal
{
   public void Move()
   {
      Console.WriteLine("Moving...");
   }
}

//class Eagle
//{
//   public void Move()
//   {
//      Console.WriteLine("Moving...");
//   }

//   public void Fly()
//   {
//      Console.WriteLine("Flying...");
//   }

//}

class Eagle : Animal
{

   public void Fly()
   {
      Console.WriteLine("Flying...");
   }

   public void DoSomething()
   {
      Console.WriteLine("Doing something...");
   }

}


