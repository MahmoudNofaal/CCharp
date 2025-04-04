using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _7_Methods
{
   public static void Ex01()
   {
      /// Difference between static and const

      /// Const
      /// - the value can be assigned at declaration and cannot change later
      /// - You can use it with primitive types and string only not with (lists,arrays,..)
      /// 
      /// Static
      /// - Belong to the class and shared to all instances of the class
      /// - Can change during the runtime
      /// - You can use it with reference types

   }

   public static void Ex02()
   {
      /// Difference between ref and out keywords
      /// 
      /// ref
      /// - the variable must be initialized before passing it as argument
      /// - the method can modify the value of the variable
      /// 
      /// out
      /// - the variable does not need to be initialized before being passed
      /// - the method must assign the variable before returning 

      Demo d = new Demo();

      var age = 18;
      d.DoSomething(ref age);
      Console.WriteLine(age); // 18

      int age2 = 21;

      d.DoSomething2(out age2);

      Console.WriteLine(age2); // 18

   }

   public static void Ex03()
   {
      // Methods Overloading

      Demo d = new Demo();

      d.Method1();
      d.Method1(18);
      d.Method1(18, "Ahmed");
      d.Method1("Ahmed", 18);

   }

   public static void Ex04()
   {
      Demo d = new Demo();

      Console.WriteLine(d.IsEven(8));
   }

}

public class Demo
{
   public void DoSomething(ref int age)
   {
      age = age + 3;
   }

   public void DoSomething2(out int age)
   {
      age = 18;
   }

   /// METHOD OVERLOADING USE THE SAME NAME OF THE METHOD
   /// WITH DIFFERENT SIGNATURES (NAME + PARAM TYPE + PARAM ORDER)
   /// 

   public void Method1()
   {
      // method body
      Console.WriteLine("Without parameters");
   }
   public void Method1(int age)
   {
      // method body
      Console.WriteLine($"Age: {age}");
   }
   public void Method1(int age, string name)
   {
      // method body
      Console.WriteLine($"Age: {age}, Name: {name}");
   }
   public void Method1(string name, int age)
   {
      // method body
      Console.WriteLine($"Name: {name}, Age: {age}");

   }

   /// METHOD
   public bool IsEven(int number) => number % 2 == 0;

}

