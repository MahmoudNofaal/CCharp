using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _29_IEnumerableAndICollection
{

   public static void Ex01()
   {
      /// WHAT IS IENUMERABLE AND ICOLLECTION AND WHAT IS DIFFERENCE
      /// they are interfaces to support collections
      /// IENUMERABLE
      /// - provides the minimal contract for iteration over a collection
      /// - generic and non-generic
      /// 
      /// ICOLLECTION
      /// - suports collection management (add,delete,count,..)
      /// 
      /// IDEA: IEnumerable like a read-only cursor for iterating data, while
      ///  ICollection is more versatile toolbox for both iterating and modifying collection

      IEnumerable<string> names = new List<string> { "Ahmed", "Marwa", "Ali" };

      foreach (string name in names)
      {
         Console.WriteLine(name);
      }

   }

   public static void Ex02()
   {
      ICollection<string> names = new List<string>();

      names.Add("Ahmed");
      names.Add("Marwa");
      names.Add("Omar");

      Console.WriteLine($"Count: {names.Count}");
      Console.WriteLine($"Contains 'Marwa': {names.Contains("Marwa")}");

      names.Remove("Omar");

      foreach (string name in names)
      {
         Console.WriteLine(name);
      }

   }

   private static void ProcessItems(IEnumerable<string> items)
   {
      foreach (string item in items) // CAN ONLY ITERATE
      {
         Console.WriteLine($"{item}, ");
      }
      //items.Add("New"); ERROR , IEnumerable has no 'Add'
   }
   private static void ManageItems(ICollection<string> items)
   {
      // can modify and query
      items.Add("New");
      Console.WriteLine($"Count: {items.Count}");
      items.Clear();
   }

   public static void Ex03()
   {
      ///what is the difference
      ///
      ///IEnumerable<T>
      ///pros: minimal interface, support lazy evalution, widely compitable
      ///cons: no modification, no metadata
      ///
      ///ICollection<T>
      ///pros: full control over collection (add,remove,clear)
      ///cons: more restrictive (not all collections support modification)

      var list = new List<string> { "Ahmed", "Marwa" };

      ProcessItems(list);

      ManageItems(list);

      Console.WriteLine($"After clear: {list.Count}");//

   }

   public static void Ex04()
   {
      ICollection<string> readOnlyList = new List<string>().AsReadOnly();

      try
      {
         readOnlyList.Add("New"); // throws an exception
      }
      catch (Exception ex)
      {
         Console.WriteLine(ex.Message);
      }

   }

   public static void Ex05()
   {
      ///[ IEnumerable<T> ]:
      /// When to Use
      /// Query methods returning multiple entities(GetAll, FindByCondition)
      /// Lazy loading from databases (e.g., Entity Framework with LINQ)
      /// Read - only access to minimize coupling.
   }

}

///JUST FOR CLARFICATION
///interface IEnumerable
///{
///   IEnumerator GetEnumerator();
///}

///interface IEnumerable<out T> : IEnumerable
///{
///   new IEnumerator<T> GetEnumerator();
///}

///JUST FOR CLARFICATION
///public interface ICollection : IEnumerable
///{
///   int Count { get; }
///   bool IsSynchronized { get; }
///   object SyncRoot { get; }
///   void CopyTo(Array array, int index);
///}

///public interface ICollection<T> : IEnumerable<T>
///{
///   int Count { get; }
///   bool IsReadOnly { get; }
///   void Add(T item);
///   bool Remove(T item);
///   void Clear();
///   bool Contains(T item);
///   void CopyTo(T[] array, int arrayIndex);
///}

