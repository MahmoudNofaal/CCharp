using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _9_Properties
{
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

