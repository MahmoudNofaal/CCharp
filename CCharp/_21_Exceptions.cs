using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _21_Exceptions
{

   public static void Ex01()
   {
      ///EXCEPTIONS
      ///IN C# ARE OBJECTS THAT REPRESENT ERRORS OR UNEXCPECTED CONDITIONS
      /// DURING PROGRAM EXECUTION
      /// 
      /// WHY USE EXCEPTIONS
      /// - Robutness: handles errors without crashing the program.
      /// - Clarity: separate error-handling code from normal logi.
      /// - Debugging: provide detailed info (stack trace) to dignose issues
      /// - Flexibility: allow custom error types for specific scenarios
      /// 
      /// Exception Class : [System.Exception]
      /// Common Properties (Message, StackTrace, InnerException)
      /// Keywords For Exception Handling (try, catch, finally, throw)

      try
      {
         Console.Write("Enter numerator: ");
         int numerator = int.Parse(Console.ReadLine());
         Console.Write("Enter denominator: ");
         int denominator = int.Parse(Console.ReadLine());

         int result = numerator / denominator;
         Console.WriteLine($"Result: {result}");

      }
      catch (DivideByZeroException)
      {
         Console.WriteLine("Error: cannot divide by zero!");
      }
      catch (FormatException)
      {
         Console.WriteLine("Error: please enter valid numbers!");
      }
      finally
      {
         Console.WriteLine($"Calculation attempt completed.");
      }

   }

   public static void Ex02()
   {
      var b = new BankAccount(5000);

      try
      {

      }
      catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException)
      {
         Console.WriteLine($"Error: {ex.Message}");
      }
      catch (Exception ex)
      {
         Console.WriteLine($"Error: {ex.Message}");
      }

   }


   async Task DoSomeWorkAsync()
   {
      await Task.Delay(1000);
      throw new InvalidOperationException("Async error");
   }
   public async Task Ex03()
   {

      try
      {
         await DoSomeWorkAsync();
      }
      catch (InvalidOperationException ex)
      {
         Console.WriteLine(ex.Message);
      }

   }

}

class BankAccount
{
   private decimal _balance;

   public BankAccount(decimal balance)
   {
      this._balance = balance;
   }

   public void Withdraw(decimal amount)
   {
      if (amount < 0)
         throw new ArgumentException("Amount cannot be less than zero", nameof(amount));
      if (amount > _balance)
         throw new InvalidOperationException("Insufficient funds!");

      _balance -= amount;
   }

}

