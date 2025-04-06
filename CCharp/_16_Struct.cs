using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _16_Struct
{
   public static void Ex01()
   {
      ///STRUCT (struct)
      ///it used to represent lightweight objects that don't require inheritance
      ///and donot need reference semantics.
      ///- it's value type stored in stack not in heap
      ///- fast and memory-efficient
      ///- cannot inheirt from another struct or class (but can implement interfaces )
      ///

      DigitalSize size = new DigitalSize(76965365300);

      Console.WriteLine(size.Bit);
      Console.WriteLine(size.Byt);
      Console.WriteLine(size.KB);
      Console.WriteLine(size.MB);
      Console.WriteLine(size.GB);
      Console.WriteLine(size.TB);

   }

   public static void Ex02()
   {
      DigitalSize size = new DigitalSize();

      var size2 = size.AddGB(1);

      Console.WriteLine(size2.Bit);
      Console.WriteLine(size2.Byt);
      Console.WriteLine(size2.KB);
      Console.WriteLine(size2.MB);
      Console.WriteLine(size2.GB);
      Console.WriteLine(size2.TB);

   }


}

public struct DigitalSize
{
   private long bit;

   private const long bitsInBit = 1;
   private const long bitsInByt = 8;
   private const long bitsInKB = bitsInByt * 1024;
   private const long bitsInMB = bitsInKB * 1024;
   private const long bitsInGB = bitsInMB * 1024;
   private const long bitsInTB = bitsInGB * 1024;

   public string Bit => $"{(bit / bitsInBit):N0} Bit";
   public string Byt => $"{(bit / bitsInByt):N0} Byt";
   public string KB => $"{(bit / bitsInKB):N0} KB";
   public string MB => $"{(bit / bitsInMB):N0} MB";
   public string GB => $"{(bit / bitsInGB):N0} GB";
   public string TB => $"{(bit / bitsInTB):N0} TB";

   public DigitalSize()
   {
      
   }

   public DigitalSize(long initialValue)
   {
      this.bit = initialValue;
   }

   public DigitalSize AddBit(long bit)
   {
      return Add(bit, bitsInBit);
   }

   public DigitalSize AddByt(long byt)
   {
      return Add(byt, bitsInByt);
   }

   public DigitalSize AddKB(long kb)
   {
      return Add(kb, bitsInKB);
   }

   public DigitalSize AddMB(long mb)
   {
      return Add(mb, bitsInMB);
   }

   public DigitalSize AddGB(long gb)
   {
      return Add(gb, bitsInGB);
   }

   public DigitalSize AddTB(long tb)
   {
      return Add(tb, bitsInTB);
   }


   private DigitalSize Add(long value, long scale)
   {
      return new DigitalSize(value * scale);
   }

}

