using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _10_Indexers
{
   public static void Ex01()
   {
      var ip = new IP(192, 168, 1, 1);

      Console.WriteLine(ip.Address);

   }

   public static void Ex02()
   {
      var ip = new IP(192, 168, 1, 1);

      var firstSegment = ip[0];

      Console.WriteLine($"First Segment: {firstSegment}");

   }

   public static void Ex03()
   {
      var ip = new IP("192.168.1.1");

      Console.WriteLine(ip.Address);
   }

}

public class IP
{
   private int[] segments = new int[4];

   public int this[int index]
   {
      get
      {
         return segments[index];
      }
      set
      {
         segments[index] = value;
      }
   }

   public IP(string IPAddress)
   {
      var segs = IPAddress.Split('.');

      for (int i = 0; i < segs.Length; i++)
      {
         segments[i] = Convert.ToInt32(segs[i]);
      }
   }


   //segment 1-255
   public IP(int s1, int s2, int s3, int s4)
   {
      segments[0] = s1;
      segments[1] = s2;
      segments[2] = s3;
      segments[3] = s4;
   }

   public string Address => string.Join(".", segments);
}

