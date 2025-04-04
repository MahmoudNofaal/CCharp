using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _11_Delegates
{

   public static void Ex01()
   {
      var emps = new Employee2[]
      {
         new Employee2 { Id = 1, Name = "Ahmed", Gender = "M", TotalSales = 65000m },
         new Employee2 { Id = 2, Name = "Khaled", Gender = "M", TotalSales = 15000m },
         new Employee2 { Id = 3, Name = "Yusra", Gender = "F", TotalSales = 44000m },
         new Employee2 { Id = 4, Name = "Hossam", Gender = "M", TotalSales = 65000m },
         new Employee2 { Id = 5, Name = "Mai", Gender = "F", TotalSales = 54000m },
         new Employee2 { Id = 6, Name = "Aliaa", Gender = "F", TotalSales = 14000m },
      };

      Report r = new Report();
      r.ProccessEmployeesWith60000PlusSales(emps);
      r.ProccessEmployeesBetween30000And59999Sales(emps);
      r.ProccessEmployeesLessThan30000Sales(emps);

   }

   public static void Ex02()
   {
      var emps = new Employee2[]
      {
         new Employee2 { Id = 1, Name = "Ahmed", Gender = "M", TotalSales = 65000m },
         new Employee2 { Id = 2, Name = "Khaled", Gender = "M", TotalSales = 15000m },
         new Employee2 { Id = 3, Name = "Yusra", Gender = "F", TotalSales = 44000m },
         new Employee2 { Id = 4, Name = "Hossam", Gender = "M", TotalSales = 65000m },
         new Employee2 { Id = 5, Name = "Mai", Gender = "F", TotalSales = 54000m },
         new Employee2 { Id = 6, Name = "Aliaa", Gender = "F", TotalSales = 14000m },
      };

      Report r = new Report();

      /// way 1
      //r.ProccessEmployeesSales(emps, "Employees with $60,000+ Sales", IsGreaterThan);
      //r.ProccessEmployeesSales(emps, "Employees Between 30,000 And 59,999 Sales", IsBetween);
      //r.ProccessEmployeesSales(emps, "Employees Less Than 30,000 Sales", IsLessThan);

      /// way 2
      //r.ProccessEmployeesSales(emps,
      //                         "Employees with $60,000+ Sales",
      //                         delegate (decimal s) { return s >= 60000m; });

      //r.ProccessEmployeesSales(emps,
      //                         "Employees Between 30,000 And 59,999 Sales",
      //                         delegate (decimal s) { return s >= 30000m && s <= 59999m ; });

      //r.ProccessEmployeesSales(emps,
      //                         "Employees Less Than 30,000 Sales",
      //                         delegate (decimal s) { return s < 30000m; });

      /// way 3
      r.ProccessEmployeesSales(emps, "Employees with $60,000+ Sales", s => s >= 60000m);
      r.ProccessEmployeesSales(emps, "Employees Between 30,000 And 59,999 Sales", s=> s >= 30000m && s <= 59999m);
      r.ProccessEmployeesSales(emps, "Employees Less Than 30,000 Sales", s => s < 30000m);

   }


   static bool IsGreaterThan(decimal sales) => sales > 60000m;
   static bool IsBetween(decimal sales) => sales >= 30000m && sales <= 59999m;
   static bool IsLessThan(decimal sales) => sales < 30000m;

}

public class Report
{
   public delegate bool ProccessSales(decimal totalSales);
   public void ProccessEmployeesSales(Employee2[] employees, string title, ProccessSales proccessSales)
   {
      Console.WriteLine(title);
      Console.WriteLine("-----------------------------");

      foreach (var item in employees)
      {
         if (proccessSales(item.TotalSales))
         {
            Console.WriteLine($"Id: {item.Id} | Name: {item.Name} |" +
               $" Gender: {item.Gender} | TotalSales: {item.TotalSales}");
         }
      }
      Console.WriteLine("\n");
   }

   public void ProccessEmployeesWith60000PlusSales(Employee2[] employees)
   {
      Console.WriteLine("Employees with $60,000+ Sales");
      Console.WriteLine("-----------------------------");

      foreach (var item in employees)
      {
         if (item.TotalSales >= 60000m)
         {
            Console.WriteLine($"Id: {item.Id} | Name: {item.Name} |" +
               $" Gender: {item.Gender} | TotalSales: {item.TotalSales}");
         }
      }
      Console.WriteLine("\n");
   }

   public void ProccessEmployeesBetween30000And59999Sales(Employee2[] employees)
   {
      Console.WriteLine("Employees Between 30,000 And 59,999 Sales");
      Console.WriteLine("-----------------------------------------");

      foreach (var item in employees)
      {
         if (item.TotalSales >= 30000m && item.TotalSales <= 59999)
         {
            Console.WriteLine($"Id: {item.Id} | Name: {item.Name} |" +
               $" Gender: {item.Gender} | TotalSales: {item.TotalSales}");
         }
      }
      Console.WriteLine("\n");
   }

   public void ProccessEmployeesLessThan30000Sales(Employee2[] employees)
   {
      Console.WriteLine("Employees Less Than 30,000 Sales");
      Console.WriteLine("-----------------------------");

      foreach (var item in employees)
      {
         if (item.TotalSales < 30000m)
         {
            Console.WriteLine($"Id: {item.Id} | Name: {item.Name} |" +
               $" Gender: {item.Gender} | TotalSales: {item.TotalSales}");
         }
      }
      Console.WriteLine("\n");
   }
}

public class Employee2
{
   public int Id { get; set; }
   public string Name { get; set; }
   public decimal TotalSales { get; set; }
   public string Gender { get; set; }
}

