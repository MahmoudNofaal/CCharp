using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _26_Queue
{

   public static void Ex01()
   {
      ///QUEUE
      ///IS A C# COLLECTION THAT OPERATES ON FIFO (FIRST IN FIRST OUT) PRINCIPLE
      ///THERE ARE NON-GENERIC AND GENERIC QUEUE IN System.Collection and .Generic
      ///
      ///WHY QUEUE
      ///- Order Preservation: maintains the sequence of the elements
      ///- Type Safety
      ///- Efficiency : O(1)
      ///- Flexbility
      ///- UseCases: Task scheduling, message passing, breadth-first search (BFS)

      var printQueue = new Queue<string>();

      printQueue.Enqueue("Document1.pdf");
      printQueue.Enqueue("Photo.jpg");
      printQueue.Enqueue("Report.docx");

      Console.WriteLine($"Count Jobs in Queue: {printQueue.Count}");
      Console.WriteLine($"Next Job: {printQueue.Peek()}");

      //making jobs
      while(printQueue.Count > 0)
      {
         string job = printQueue.Dequeue();
         Console.WriteLine($"Printing: {job}");
      }

   }

   public static void Ex02()
   {
      ///NON-GENERIC QUEUE
      ///
      var q = new Queue();

      q.Enqueue("Document");
      q.Enqueue(42);

      Console.WriteLine(q.Peek());

      foreach(var qq in q)
      {
         Console.WriteLine(qq);
      }

   }

   public static void Ex03()
   {
      var numbers = new Queue<int>();

      try
      {
         int item = numbers.Dequeue(); // throw InvalidOperationException
      }
      catch (InvalidOperationException ex)
      {
         Console.WriteLine($"Error: {ex.Message}");
      }

      numbers.Enqueue(1);
      if (numbers.Count > 0)
      {
         Console.WriteLine(numbers.Dequeue());
      }
   }

}


