using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _6_FieldesAndConstants
{
   public static void Ex01()
   {
      Employee emp = new Employee();

      Console.Write($"First Name: ");
      emp.FirstName = Console.ReadLine();

      Console.Write($"Last Name: ");
      emp.LastName = Console.ReadLine();

      Console.Write($"Wage: ");
      emp.Wage = Convert.ToDouble(Console.ReadLine());

      Console.Write($"Logged Hours: ");
      emp.LoggedHours  = Convert.ToDouble(Console.ReadLine());

      var netSalary = emp.Wage * emp.LoggedHours - (emp.Wage * emp.LoggedHours * Employee.TAX);

      Console.WriteLine($"First Name: {emp.FirstName}");
      Console.WriteLine($"Last Name: {emp.LastName}");
      Console.WriteLine($"Wage: {emp.Wage}");
      Console.WriteLine($"Logged Hours: {emp.LoggedHours}");
      Console.WriteLine($"Net Salary: {netSalary}");


   }


}

public class Employee
{
   public const double TAX = 0.03;

   public string FirstName;
   public string LastName;
   public double Wage;
   public double LoggedHours;

}


