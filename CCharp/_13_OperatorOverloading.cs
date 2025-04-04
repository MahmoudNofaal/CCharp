using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _13_OperatorOverloading
{
   public static void Ex01()
   {
      Money m1 = new Money(10);
      Money m2 = new Money(20);

      Money m3 = m1 + m2;

      Console.WriteLine($"Amount Of Money 3 : {m3.Amount}");

      
   }

}

public class Money
{
   public decimal Amount { get; set; }

   public Money(decimal value)
   {
      this.Amount = Math.Round(value);
   }

   public static Money operator +(Money m1, Money m2)
   {
      var value = m1.Amount + m2.Amount;

      return new Money(value);
   }

}

