using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _31_Threading
{

   public static void Ex01()
   {
      ///WHAT IS THREADING
      ///* is the ability to execute multiple threads-independent paths of execution
      /// within a single process.
      ///* Allowing tasks to run in parallel or appear simultaneous on single CPU
      /// via time-slicing.
      /// 
      /// WHY THREADING?
      /// - Responsiveness: Keep UI responsive while performing background tasks
      ///   like (file downloading)
      /// - Performance: {image processing}
      /// - Concurrency: Handles multiple operations simultaneously (Serving API Requests)
      /// - Scalability
      /// - Asynchrony: handles (database queries, HTTP calls) without blocking.
   }

   public static void Ex02()
   {
      var wallet = new Wallet("Omar", 80);

      wallet.RunRandomTransaction();

      Console.WriteLine("----------------\n");

      Console.WriteLine($"{wallet}\n");

      Console.WriteLine();

      wallet.RunRandomTransaction();

      Console.WriteLine("----------------\n");

      Console.WriteLine($"{wallet}\n");

   }

   public static void Ex03()
   {
      var wallet = new Wallet("Ali", 50);

      var t1 = new Thread(() => wallet.Debit(40));
      var t2 = new Thread(() => wallet.Debit(30));

      t1.Start();
      t2.Start();

      t1.Join();
      t2.Join();

      Console.WriteLine(wallet);

   }

   public static void Ex04()
   {
      var w1 = new Wallet("Ahmed", 100);
      var w2 = new Wallet("Marwa", 50);

      Console.WriteLine("Before Transaction");
      Console.WriteLine("------------------");

      Console.WriteLine(w1);
      Console.WriteLine(w2);

      Console.WriteLine("After Transaction");
      Console.WriteLine("-----------------");

      var transfer = new TransferManager(w1, w2, 50);

      transfer.Transfer();

      Console.WriteLine(w1);
      Console.WriteLine(w2);

   }

   static void DoWork()
   {
      Console.WriteLine("Worker thread started.");
      Thread.Sleep(1000); // Simulate long task
      Console.WriteLine("Worker thread finished.");
   }
   public static void Ex05()
   {
      var t = new Thread(DoWork);
      t.IsBackground = true; // Terminates when Main ends
      t.Start();

      Console.WriteLine("Main thread working...");
      Thread.Sleep(500);
      Console.WriteLine("Main thread done.");
   }

   static List<int> numbers = [];
   static void AddNumbers()
   {
      for (int i = 0; i < 1000; i++)
      {
         numbers.Add(i);
      }
   }
   public static void Ex06()
   {
      Thread t1 = new Thread(AddNumbers);
      Thread t2 = new Thread(AddNumbers);

      t1.Start();
      t2.Start();

      t1.Join();
      t2.Join();

      Console.WriteLine($"Count: {numbers.Count}");
   }

   public static void Ex07()
   {
      Task task = Task.Run(() =>
      {
         Console.WriteLine("Task running...");
         Task.Delay(1000).Wait();
         Console.WriteLine("Task done.");
      });

      Console.WriteLine("Main thread working...");
      task.Wait(); // Block until task complete
   }


}

class Wallet
{
   private readonly object locker = new object();

   public Wallet(string name, int bitCoins)
   {
      Name = name;
      BitCoins = bitCoins;
   }

   public string Name { get; private set; }
   public int BitCoins { get; private set; }

   public void Debit(int amount)
   {
      lock (locker)
      {
         if (BitCoins >= amount)
         {
            Thread.Sleep(1000);
            BitCoins -= amount;
         }
      }
   }

   public void Credit(int amount)
   {
      BitCoins += amount;
   }

   public void RunRandomTransaction()
   {
      var amounts = new int[] { 10, 20, 30, -20, 10, -10, 30, -10, 40, -20 };

      foreach (var amount in amounts)
      {
         var absValue = Math.Abs(amount);

         if (amount < 0)
         {
            Debit(absValue);
         }
         else
         {
            Credit(absValue);
         }
         Console.WriteLine($"[Thread: {Thread.CurrentThread.ManagedThreadId}," +
            $" Proccessor Id: {Thread.GetCurrentProcessorId()}] {amount}");
      }

   }

   public override string ToString()
   {
      return $"[{Name} -> {BitCoins} Bitcoins]";
   }

}

class TransferManager
{
   private Wallet _from;
   private Wallet _to;
   private int _amountToTransfer;

   public TransferManager(Wallet from, Wallet to, int amountToTransfer)
   {
      _from = from;
      _to = to;
      _amountToTransfer = amountToTransfer;
   }

   public void Transfer()
   {
      Console.WriteLine($"{Thread.CurrentThread.Name} trying to lock... {_from}");

      lock (_from)
      {
         Console.WriteLine($"{Thread.CurrentThread.Name} lock acquired... {_from}");
         Thread.Sleep(1000);

         Console.WriteLine($"{Thread.CurrentThread.Name} trying to lock... {_to}");
         lock (_to)
         {
            Console.WriteLine($"{Thread.CurrentThread.Name} lock acquired... {_to}");
            Thread.Sleep(1000);
         }

      }

   }
}

