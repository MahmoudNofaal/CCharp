using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _15_NestedTypes
{

   public static void Ex01()
   {
      ///ACCESS MODIFIERS
      ///PUBLIC (public)
      ///- you can access from anywhere class, namespace, project,...
      ///
      ///PRIVATE (private)
      ///- only access withing the same class.
      ///
      ///PROTECTED (protected)
      ///- accessed with same classes + inherited (child) classes even with different assemblies.
      ///
      ///INTERNAL (internal)
      ///- an class with the same project but not other projects.
      ///
      ///PROTECTED INTERNAL (protected internal)
      ///- same project or any derived class even with different projects.
      ///
      ///PRIVATE PROTECTED
      ///- only with the same class  or derived classes in the same project.
      ///
   }

   public static void Ex02()
   {
      /// COMPOSITIION
      /// it is type of relationship between classes - has a (relation with)
   }

}

public class A
{
   private int x;
   public class B
   {
      public int Y;

      public B()
      {
         A a = new A();

         // i can acces private x in the same class A
         Y = a.x;
      }
   }
}

public class Employee3
{
   public int Id { get; set; }
   public string Name { get; set; }

   public Insurance Insurance { get; set; }
}

public class Insurance
{
   public int PolicyId { get; set; }
   public string CompanyName { get; set; }
}

public class Department
{
   public int Id { get; set; }
   public string Name { get; set; } 
}

