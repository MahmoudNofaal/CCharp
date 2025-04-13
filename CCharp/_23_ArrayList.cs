using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _23_ArrayList
{

   public static void Ex01()
   {
      ///WHY ARRAYLIST
      ///- DYNAMIC SIZE
      ///- VERSATILITY: ALLOW STORE MIXED TYPES (int, string,..) 
      ///
      ///IMPLEMENTS INTERFACES:
      ///IEnumerable: supports foreach
      ///ICollection: provides count, add,..
      ///IList: enable indexing ([i]), insert, remove
      ///

      var list = new ArrayList();

      list.Add(42);
      list.Add("spider");
      list.Add(3.14);

      Console.WriteLine($"Count: {list.Count}"); //Count
      Console.WriteLine($"Index 0: {list[0]}"); //index 0

      foreach(object item in list)
      {
         Console.WriteLine(item);
      }

   }

   public static void Ex02()
   {
      var nums = new ArrayList { 5, 3, 1, 8 };

      nums.Sort();

      Console.WriteLine(string.Join(", ", nums.ToArray()));

      int index = nums.BinarySearch(3);
      Console.WriteLine($"Index of number 3: {index}");

   }

   public static void Ex03()
   {
      ArrayList list = new ArrayList();

      list.Add(1);

      Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");

   }


}
