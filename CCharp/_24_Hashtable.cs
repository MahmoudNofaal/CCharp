using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _24_Hashtable
{

   public static void Ex01()
   {
      ///HASHTABLE:
      ///IT'S A KEY-VALUE PAIR DATA STRUCTURE THAT STORES ELEMENTS AS
      ///OBJECTS TYPES.
      ///IT USES HASHING TO PROVIDE FAST LOOKUPS
      ///
      /// WHY HASHTABLE ?
      /// - Fast Lookups: O(1)
      /// - Flexibility
      /// - Dynamic Size
      /// 
      /// NOTE::::::
      /// => Dictionary<TKey, TValue> IS PREFERED FOR TYPE SAFETY AND PERFORMANCE.
      /// 

      var users = new Hashtable();

      users.Add(1, "Ahmed"); // add key-value
      users[2] = "Omar"; // use indexer
      users.Add("VIP", "Khaled"); // mixed key types

      Console.WriteLine($"User1: {users[1]}");
      Console.WriteLine($"Users Count: {users.Count}");

      Console.WriteLine("Key - Value");
      foreach (DictionaryEntry item in users )
      {
         Console.WriteLine($"{item.Key} - {item.Value}");
      }

   }

   public static void Ex02()
   {
      var table = new Hashtable();

      try
      {
         table.Add(null, "Value"); // throws an ArgumentNullException
      }
      catch (Exception ex)
      {
         Console.WriteLine($"Error: {ex.Message}");
      }

      table.Add(1, "John");
      try
      {
         table.Add(1, "Duplicate"); // duplicated keys
      }
      catch (Exception ex)
      {
         Console.WriteLine($"Error: {ex.Message}");
      }

   }

   public static void Ex03()
   {
      var hashTable = new Hashtable();
      hashTable.Add(1, "One");
      string s1 = (string)hashTable[1];

      ///Dictionary
      var dictionary = new Dictionary<int, string>();
      dictionary.Add(1, "One");
      string s2 = dictionary[1]; // no cast needed

      Console.WriteLine($"Hashtable: {s1}, Dictionary: {s2}");
   }

}


