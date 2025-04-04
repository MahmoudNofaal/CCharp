using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _9_Properties
{
   public static void Ex01()
   {
      Dollar d = new Dollar();

      d.Amount = 15.5m;

      Console.WriteLine($"{d.Amount}$");

   }

}


public class Dollar
{
   private decimal _amount;

   public decimal Amount
   {
      get
      {
         return _amount;
      }
      set
      {
         if (value < 0)
         {
            this._amount = 0;
         }
         this._amount = value;
      }
   }

}

