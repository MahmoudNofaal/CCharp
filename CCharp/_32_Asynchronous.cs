using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _32_Asynchronous
{
   static async Task<string> FetchDataAsync()
   {
      using HttpClient client = new HttpClient();

      //simulate API call
      await Task.Delay(1000); // pretend it takes time

      return "Hellow, spider!";
   }
   public static async Task Ex01()
   {
      ///Asynchronous
      ///* allows tasks to run independently of main thread, enabling
      ///  non-blocking execution.
      ///* instead of waiting for a task (reading a file, querying a database)
      ///  to complete, the program can continue other work and handle the result
      ///  when its ready.
      /// 
      /// SYNCHRONOUS: Code executes sequentially, blocking until each operation completes.
      /// ASYNCHRONOUS: Code can start an operation and proceed without waiting, resuming
      ///               when the operation finishes
      ///               

      Console.WriteLine("Starting...");

      string result = await FetchDataAsync();

      Console.WriteLine($"Result: {result}");

      Console.WriteLine("Done.");
   }

   static async Task DoWorkAsync(CancellationToken token)
   {
      await Task.Delay(1000, token); // throw if canceled
      Console.WriteLine("Work completed.");
   }
   public static async Task Ex02()
   {
      CancellationTokenSource cts = new CancellationTokenSource();
      cts.CancelAfter(500); // Cancel after 500

      try
      {
         await DoWorkAsync(cts.Token);
      }
      catch (OperationCanceledException)
      {
         Console.WriteLine("Operation was canceled.");
      }
   }

}

