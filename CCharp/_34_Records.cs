using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _34_Records
{

   public static void Ex01()
   {
      ///RECORDS
      ///* They are a special kind of type designed to simplfy the creation
      ///  of immutable or value-like data structures
      ///  

      var u1 = new User4(1, "Ahmed");
      var u2 = new User4(1, "Ahmed");
      var u3 = new User4(2, "Marwa");

      Console.WriteLine(u1 == u2);
      Console.WriteLine(u1 == u3);

      Console.WriteLine(u1);

      var (id, name) = u1;

      Console.WriteLine($"Id: {id}, Name: {name}");

   }

   public static void Ex02()
   {
      var  user = new User5(1, "Ahmed");

      Console.WriteLine(user.GetGreeting());

      user.LoginCount++;

      Console.WriteLine(user.LoginCount);
   }

   public static void Ex03()
   {
      var user1 = new User4(1, "Ahmed");
      var user2 = user1 with { Name = "Marwa" };

      Console.WriteLine(user1);
      Console.WriteLine(user2);

      Console.WriteLine(user1 == user2); // false
   }

   public static void Ex04()
   {
      Animal2 dog = new Dog2("Rex", "Breed");
      Animal2 cat = new Cat("Cota", true);

      Console.WriteLine(dog); 
      Console.WriteLine(cat);

      Console.WriteLine(dog.Equals(new Dog2("Rex", "Breed")));
   }

}

record User4(int Id, string Name);

public record User5(int Id, string Name)
{
   // Mutable field (use sparingly)
   private int _loginCount;

   public int LoginCount
   {
      get => _loginCount;
      set => _loginCount = value;
   }

   public string GetGreeting() => $"Hello, {Name}!";
}

public abstract record Animal2(string Name);
public record Dog2(string Name, string Breed) : Animal2(Name);
public record Cat(string Name, bool IsIndoor) : Animal2(Name);

