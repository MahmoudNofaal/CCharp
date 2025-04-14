using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CCharp;

public class _30_StreamIO
{

   public static void Ex01()
   {
      ///SYSTEM I/O
      ///refers to reading and writing data as a sequence of bytes using the abstract
      ///class [System.IO.Stream].
      ///A stream represents a flow of data, such as file, network connection, or memory buffer
      ///providing a unified way to handle input/output operations.
      ///
      ///WHY USE STREAM???
      ///- Abstraction: work with diverse data sources (files, memory, network)
      ///- Flexibility: support sequential or random access, synchrnous and asynchronous operations.
      ///- Type Safety
      ///- Efficiency: buffer data to minimize system calls
      ///- Use Cases: File Handling, Network Communication, Serialization, Logging.
      ///
      /// Key properties:
      /// [ CanRead ]: Indicates if the stream supports reading.
      /// [ CanWrite ]: Indicates if the stream supports writing.
      /// [ CanSeek ]: Indicates if the stream supports seeking(random access).
      /// [ Length / Position ]: Size and current position(for seekable streams).
      /// 
      /// Key methods :
      /// [ Read(byte[], int offset, int count) ]: Reads bytes into an array.
      /// [ Write(byte[], int offset, int count) ]: Writes bytes from an array.
      /// [ Seek(long offset, SeekOrigin) ]: Moves the position(if seekable).
      /// [ Flush() ]: Ensures buffered data is written.
      /// [ Close() / Dispose() ]: Releases resources.
   }

   public static void Ex02()
   {
      var currency = new CurrencyService();

      var result = currency.GetCurrencies();

      Console.WriteLine(result);

   }

   public static void Ex03()
   {
      string path = "example.txt";

      // writing to a file
      using (var fs = new FileStream(path, FileMode.Create))
      {
         byte[] data = Encoding.UTF8.GetBytes("Hello, Spider!");

         fs.Write(data, 0, data.Length);
      }

      // reading from a file
      using (var fs = new FileStream(path, FileMode.Open))
      {
         byte[] buffer = new byte[fs.Length];

         int bytesToRead = fs.Read(buffer, 0, buffer.Length);

         string content = Encoding.UTF8.GetString(buffer, 0, bytesToRead);

         Console.WriteLine(content);
      }

   }

   public static void Ex04()
   {
      ///Why It’s Practical:
      /// Handles text directly,
      /// avoiding manual byte conversions.
      /// Connection to Exceptions: File operations may throw IOException.
      ///

      string path = "example2.txt";

      // writing text
      using (var writer = new StreamWriter(path))
      {
         writer.WriteLine("Line 1");
         writer.WriteLine("Line 2");
      }

      // reading text
      using (var reader = new StreamReader(path))
      {
         string content = reader.ReadToEnd();

         Console.WriteLine(content);
      }

   }

   public static void Ex05()
   {
      using (FileStream fs = new FileStream("data.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite))
      {
         fs.WriteByte(65); // Writes 'A'
      }
   }

   public static void Ex06()
   {
      using (MemoryStream ms = new MemoryStream())
      {
         byte[] data = Encoding.UTF8.GetBytes("Test");

         ms.Write(data, 0, data.Length);

         Console.WriteLine(ms.Length); // 4
      }
   }

   public static void Ex07()
   {
      try
      {
         using (FileStream fs = new FileStream("missing.txt", FileMode.Open))
         {
            // Will not reach here
         }
      }
      catch (FileNotFoundException ex)
      {
         Console.WriteLine($"Error: {ex.Message}");
      }
      catch (IOException ex)
      {
         Console.WriteLine($"IO Error: {ex.Message}");
      }
   }

   public static void Ex08()
   {
      var lines = new List<string> { "Line 1", "Line 2" };

      // Write list to file
      using (var writer = new StreamWriter("example3.txt"))
      {
         foreach (string line in lines)
         {
            writer.WriteLine(line);
         }
      }

      // Read into list
      var readLines = new List<string>();
      using (var reader = new StreamReader("example3.txt"))
      {
         string line;
         while ((line = reader.ReadLine()) != null)
         {
            readLines.Add(line);
         }
      }

      Console.WriteLine(string.Join(", ", readLines));
   }

   public static void Ex09()
   {
      LogProcessor processor = new LogProcessor();

      processor.AddLog("Error at 10:00");

      processor.AddLog("Warning at 10:01");

      processor.SaveLogs("logs.txt");
   }

}

class CurrencyService
{
   private readonly HttpClient _httpClient;

   public CurrencyService()
   {
      this._httpClient = new HttpClient();
   }

   public string GetCurrencies()
   {
      string url = "https://coinbase.com/api/v2/currencies";

      var result = _httpClient.GetStringAsync(url).Result;

      return result;
   }


}

public class LogProcessor
{
   private readonly Queue<string> logQueue = new Queue<string>();

   public void AddLog(string message)
   {
      logQueue.Enqueue(message);
   }

   public void SaveLogs(string path)
   {
      using (StreamWriter writer = new StreamWriter(path, true))
      {
         while (logQueue.Count > 0)
         {
            writer.WriteLine(logQueue.Dequeue());
         }
      }
   }

}

