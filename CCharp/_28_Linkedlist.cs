using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _28_Linkedlist
{
   public static void Ex01()
   {
      ///LINKEDLIST
      ///It's a doubly-linked list, where each element (node) contains a value
      /// of type T and references to the next and previous nodes.
      /// 
      /// The structure allows efficient insertions and deletions at any position,
      /// unlike array which is contiguous.
      /// 
      /// WHY LINKEDLIST
      /// Efficient: O(1)
      /// Dynamic Size
      /// Type Safety
      /// Bidirectional: Doubly-linked, allow traversal or backward
      /// Use Cases: Queue, Stack,..
      /// 

      var playlist = new LinkedList<string>();

      playlist.AddLast("Song1");
      playlist.AddLast("Song2");
      playlist.AddFirst("Song0");

      Console.WriteLine($"Songs Count: {playlist.Count}");
      Console.WriteLine($"First Song: {playlist?.First?.Value}");
      Console.WriteLine($"Last Song: {playlist?.Last?.Value}");

      foreach(var item in playlist)
      {
         Console.WriteLine(item);
      }

   }

   public static void Ex02()
   {
      var numbers = new LinkedList<int>();

      numbers.AddLast(1); // 1

      LinkedListNode<int> node2 = numbers.AddLast(2); // 1 2

      numbers.AddLast(3); // 1 2 3

      numbers.AddBefore(node2, 10); // 1 10 2 3

      numbers.AddAfter(node2, 10); // 1 10 2 10 3

      numbers.Remove(node2); // 1 10 10 3

      foreach (var item in numbers)
      {
         Console.Write(item + ", ");
      }

   }

   public static void Ex03()
   {
      var list = new LinkedList<string>();

      try
      {
         list.RemoveFirst();
      }
      catch (Exception ex)
      {
         Console.WriteLine("Error: "+ex.Message);
      }

      list.AddLast("Item1");
      if(list.Count > 0)
      {
         Console.WriteLine(list?.First?.Value);
      }

   }

   public static void Ex04()
   {
      var tasks = new LinkedList<Tasks>();
      
      tasks.AddLast(new Tasks("Code1"));

      var testNode = tasks.AddLast(new Tasks("Test2"));

      var task3 = new Tasks("Design3");
      tasks.AddBefore(testNode, task3);

      foreach (var item in tasks)
      {
         Console.WriteLine(item.Name);
      }

   }

}

class Tasks
{
   public string Name { get; set; }

   public Tasks(string name) => Name = name;

}

