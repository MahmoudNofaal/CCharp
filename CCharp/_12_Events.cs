using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _12_Events
{
   public static void Ex01()
   {
      var stock = new Stock("Amazon");
      stock.Price = 100;

      Console.WriteLine($"Stock Price Before Change: {stock}");
      stock.ChangeStockPriceBy(0.05m);
      Console.WriteLine($"Stock Price After Change: {stock}");

   }

   public static void Ex02()
   {
      var stock = new Stock("Amazon");
      stock.Price = 100;
      stock.OnPriceChange += Stock_OnPriceChange; //SUBSCRIBE THE EVENT HERE!

      stock.ChangeStockPriceBy(0.05m);

      stock.ChangeStockPriceBy(-0.02m);

      stock.ChangeStockPriceBy(0.00m);

   }

   private static void Stock_OnPriceChange(Stock stock, decimal oldPrice)
   {
      string result = "";
      if (stock.Price > oldPrice)
      {
         Console.ForegroundColor = ConsoleColor.Green;
         result = "UP";
      }
      else if (stock.Price < oldPrice)
      {
         Console.ForegroundColor = ConsoleColor.Red;
         result = "DOWN";
      }
      else
      {
         Console.ForegroundColor = ConsoleColor.Gray;
         result = "FIXED";
      }
      Console.WriteLine($"Stock: {stock.Name} | New Price: {stock.Price} - {result}");
   }
}


public delegate void StockPriceChangeHandler(Stock stock, decimal oldPrice);

public class Stock
{
   private string name;
   private decimal price;

   public event StockPriceChangeHandler OnPriceChange;

   public string Name => this.name;
   public decimal Price { get; set; }

   public Stock(string stockName)
   {
      this.name = stockName;
   }

   public void ChangeStockPriceBy(decimal percent)
   {
      decimal oldPrice = this.price;
      this.price += Math.Round(this.price * percent, 2);

      //ASKING IF THERE IS AT LEAST ONE SUBSCRIBER ON THE EVENNT
      if (OnPriceChange is not null)
      {
         OnPriceChange(this, oldPrice); //FIRING THE EVENT FROM THIS POINT
      }

   }


}

