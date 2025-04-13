using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _25_Dictionary
{

   public static void Ex01()
   {
      ///DICTIONARY
      ///ITS A KEY-VALUE PAIR DATA STRUCTURE THAT STORES ELEMENTS WITH
      ///UNIQUE KEY TYPE TKey AND A CORRESPONDING VALUE OF TYPE TValue.
      ///
      ///WHY DICTIONARY
      ///- Fastlookups: O(1)
      ///- Type Safety
      ///- Efficiency
      ///- Flexibility
      ///- Prefered over Hashtable!
      ///

      var students = new Dictionary<int, string>();

      students.Add(101, "Ahmed");
      students[102] = "Ali";
      students.Add(103, "Marwa");

      Console.WriteLine($"Student 101: {students[101]}");
      Console.WriteLine($"Count: {students.Count}");

      foreach(KeyValuePair<int,string> pair in students)
      {
         Console.WriteLine($"Id: {pair.Key}, Name: {pair.Value}");
      }

   }

   public static void Ex02()
   {
      var scores = new Dictionary<string, int>
      {
         { "Ahmed", 95},
         { "Marwa", 80}
      };

      //FOR SAFE ACCESS
      if(scores.TryGetValue("Ahmed", out int ahmedScore))
      {
         Console.WriteLine($"Ahmed score: {ahmedScore}");
      }

      if(!scores.TryGetValue("Ali", out int aliScore))
      {
         Console.WriteLine("Ali not found!");
      }

   }

   public static void Ex03()
   {
      var products = new Dictionary<ProductId, string >();

      ProductId id1 = new ProductId(1);

      products.Add(id1, "Laptop");

      Console.WriteLine(products[id1]);
      Console.WriteLine(products[new ProductId(1)]);
   }

   public static void Ex04()
   {
      var dict = new Dictionary<int, string>();

      try
      {
         dict.Add(1, "One");
         dict.Add(1, "Duplicate"); // throw ArgumentException
      }
      catch (ArgumentException ex)
      {
         Console.WriteLine($"Error: {ex.Message}");
      }

      try
      {
         Console.WriteLine(dict[2]); // throw KeyNotFoundException
      }
      catch (KeyNotFoundException ex)
      {
         Console.WriteLine($"Error: {ex.Message}");
      }
   }

   public static void Ex05()
   {
      var repo = new Repository<User>();

      repo.Add(new User(1, "Ahmed"));

      User user = repo.Get(1);

      Console.WriteLine(user?.Name);

   }

}

class ProductId
{
   public int Id { get; }

   public ProductId(int id) => Id = id;

   public override int GetHashCode()
   {
      return Id.GetHashCode();
   }

   public override bool Equals(object? obj)
   {
      return obj is ProductId other && Id == other.Id;
   }

}

interface IEntity
{
   int Id { get; }
}

class User : IEntity
{
   public int Id { get; }
   public string Name { get; }

   public User(int id, string name) => (Id, Name) = (id, name);
}

class Repository<T> where T : class, IEntity
{
   private readonly Dictionary<int, T> items = new Dictionary<int, T>();

   public void Add(T item)
   {
      if(item is null)
         throw new ArgumentNullException(nameof(item));

      items[item.Id] = item;
   }

   public T Get(int id)
   {
      return items.TryGetValue(id, out T item) ? item : null;
   }

}

