using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _19_Interface
{
   public static void Ex01()
   {
      ///INTERFACE
      ///- IT DEFINES AS WHAT A CLASS MUST DO, BUT NOT HOW IT DOES IT
      ///- ANY CLASS SIGN A CONTRACT(implements the interface)
      ///

      var movers = new IMovable[]
      {
         new Bird("Eagle"),
         new Fish("Salmon"),
      };

      foreach (var mover in movers)
      {
         mover.Move();
      }

   }

   public static void Ex02()
   {
      var a1 = new App(new ConsoleLogger());
      var a2 = new App(new FileLogger());

      a1.DoWork();
      a2.DoWork();

   }

   public static void Ex03()
   {
      var f = new Factory();

      f.Process(new Robot());
      f.Process(new Human("John"));

   }



}

interface IMovable
{
   void Move();
}

class Bird : IMovable
{
   public string Name { get; set; }

   public Bird(string name)
   {
      this.Name = name;
   }

   public void Move()
   {
      Console.WriteLine($"{Name} flies through the air.");
   }
}

class Fish : IMovable
{
   public string Name { get; set; }

   public Fish(string name)
   {
      Name = name;
   }

   public void Move()
   {
      Console.WriteLine($"{Name} swims in the water.");
   }
}

/////////////////////////////////////////


interface ILogger
{
   void Log(string message);
}

class ConsoleLogger : ILogger
{
   public void Log(string message)
   {
      Console.WriteLine($"Console: {message}");
   }
}

class FileLogger : ILogger
{
   public void Log(string message)
   {
      Console.WriteLine($"File: {message} (act like this is a file)");
   }
}

class App
{
   private readonly ILogger _logger;

   public App(ILogger logger)
   {
      this._logger = logger; ///INJECT THE LOGGER
   }

   public void DoWork()
   {
      _logger.Log("Work is being done!");
   }

}

////////////////////////////
///

interface IWorker
{
   string Name { get; }
   void Work();
}

class Robot : IWorker
{
   public string Name => "R2D2";

   public void Work()
   {
      Console.WriteLine($"{Name} process data.");
   }
}

class Human : IWorker
{
   public string Name { get; }

   public Human(string name)
   { 
      Name = name;
   }

   public void Work()
   {
      Console.WriteLine($"{Name} writes code.");
   }
}

class Factory
{
   public void Process(IWorker worker) // Any IWorker works here
   {
      worker.Work();
   }
}

