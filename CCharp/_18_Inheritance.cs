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

      var l = new Lion("Simba", 5);
      var e = new Eagle("Eagle1", 2);

      l.Eat();
      l.Roar();

      e.Eat();
     e.Fly();

   }

   public static void Ex02()
   {
      var animals = new List<Animal02>
      {
         new Dog("Duddy"),
         new Animal02("Animal")
      };
      
      foreach(var a in animals)
      {
         a.MakeSound();
      }

   }



}

class Animal
{
   public string Name { get; set; }
   public int Age { get; set; }

   public Animal(string name, int age)
   {
      this.Name = name;
      this.Age = age;
   }

   public void Eat()
   {
      Console.WriteLine($"{Name} is eating.");
   }

}

class Lion : Animal
{
   public Lion(string name, int age) : base(name, age)
   {

   }

   public void Roar()
   {
      Console.WriteLine($"{Name} roars loadly!");
   }
}

class Eagle : Animal
{
   public Eagle(string name, int age) : base(name, age)
   {
      
   }

   public void Fly()
   {
      Console.WriteLine($"{Name} is flying!");
   }

}

class Animal02
{
   public string Name { get; set; }

   public Animal02(string name)
   {
      this.Name=name;
   }

   ///VIRTUAL METHOD, THAT CAN BE CUSTOMIZED BY THE DERIVED CLASS
   public virtual void MakeSound()
   {
      Console.WriteLine($"{Name} makes a generic sound!");
   }

}

class Dog : Animal02
{
   public Dog(string name) : base(name)
   {
   }

   ///OVERRIDE THE DEFAULT BEHAVOIR
   public override void MakeSound()
   {
      Console.WriteLine($"{Name} barks: Woof!");
   }

}

