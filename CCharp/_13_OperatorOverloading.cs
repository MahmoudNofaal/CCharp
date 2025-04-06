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

      Console.WriteLine($"Result of m1 + m2 : {m3.Amount}");

   }

   public static void Ex02()
   {
      Money m1 = new Money(10);
      Money m2 = new Money(20);

      Money m3 = m1 - m2;

      Console.WriteLine($"Result of m1 - m2 : {m3.Amount}");

   }

   public static void Ex03()
   {
      Money m1 = new Money(10);
      Money m2 = new Money(20);

      bool m3 = m1 > m2;

      Console.WriteLine($"Result of m1 > m2 : {m3}");

   }

   public static void Ex04()
   {
      Money m1 = new Money(10);
      Money m2 = new Money(20);

      bool m3 = m1 < m2;

      Console.WriteLine($"Result of m1 < m2 : {m3}");

   }

   public static void Ex05()
   {
      Money m1 = new Money(10);
      Money m2 = new Money(20);

      bool m3 = m1 >= m2;

      Console.WriteLine($"Result of m1 >= m2 : {m3}");

   }

   public static void Ex06()
   {
      Money m1 = new Money(10);
      Money m2 = new Money(20);

      bool m3 = m1 <= m2;

      Console.WriteLine($"Result of m1 <= m2 : {m3}");

   }

   public static void Ex07()
   {
      Money m1 = new Money(10);
      Money m2 = new Money(20);

      bool m3 = m1 == m2;

      Console.WriteLine($"Result of m1 == m2 : {m3}");

   }

   public static void Ex08()
   {
      Money m1 = new Money(10);
      Money m2 = new Money(20);

      bool m3 = m1 != m2;

      Console.WriteLine($"Result of m1 != m2 : {m3}");

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

   public static Money operator -(Money m1, Money m2)
   {
      var value = m1.Amount - m2.Amount;

      return new Money(value);
   }

   public static bool operator >(Money m1, Money m2)
   {
      return m1.Amount > m2.Amount;
   }

   public static bool operator <(Money m1, Money m2)
   {
      return m1.Amount < m2.Amount;
   }

   public static bool operator >=(Money m1, Money m2)
   {
      return m1.Amount >= m2.Amount;
   }

   public static bool operator <=(Money m1, Money m2)
   {
      return m1.Amount <= m2.Amount;
   }

   public static bool operator ==(Money m1, Money m2)
   {
      return m1.Amount == m2.Amount;
   }

   public static bool operator !=(Money m1, Money m2)
   {
      return m1.Amount != m2.Amount;
   }

}

