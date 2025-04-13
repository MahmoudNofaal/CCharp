using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharp;

public class _27_Stack
{

   public static void Ex01()
   {
      ///STACK  
      ///IS A C# COLLECTION THAT OPERATES ON LIFO (LAST IN FIRST OUT) PRINCIPLE  
      ///THERE ARE NON-GENERIC AND GENERIC QUEUE IN System.Collection and .Generic  
      ///  
      ///WHY STAC  
      ///- Order REVERSAL: for scenario like backtracking or undo  
      ///- Type Safety  
      ///- Efficiency : O(1)  
      ///- Flexbility  
      ///- UseCases: Undo/redo, expression evalution, depth-first search (DFS)  
      ///  
      var actions = new Stack<string>();

      actions.Push("Edit text");
      actions.Push("Change font");
      actions.Push("Insert image");

      Console.WriteLine($"Actions in stack: {actions.Count}");
      Console.WriteLine($"Last action: {actions.Peek()}"); // last action to make  

      // Undoing actions  
      while (actions.Count > 0)
      {
         string action = actions.Pop();
         Console.WriteLine($"Undoing: {action}");
      }

   }

   public static void Ex02()
   {
      var numbers = new Stack<int>();

      try
      {
         int item = numbers.Pop(); // throw InvalidOperationException  
      }
      catch (InvalidOperationException ex)
      {
         Console.WriteLine($"Error: {ex.Message}");
      }

      numbers.Push(1);
      if (numbers.Count > 0)
      {
         Console.WriteLine(numbers.Pop());
      }
   }

   public static void Ex03()
   {
      var actions = new Stack<string>();
      actions.Push("Task1");
      actions.Push("Task2");
      actions.Push("Task3");

      foreach (string action in actions)
      {
         Console.WriteLine(action);
      }

      string[] actionArray = actions.ToArray();
      Console.WriteLine(string.Join(", ", actionArray));
   }

   public static void Ex04()
   {
      var undoStack = new Stack<Command>();

      undoStack.Push(new Command("Insert text"));
      undoStack.Push(new Command("Change color"));

      while (undoStack.Count > 0)
      {
         Command cmd = undoStack.Pop();
         Console.WriteLine($"Undo: {cmd.Description}");
      }
   }

   ///The popular problem that stack can solve
   ///
   static int EvaluatePostfix(string expression)
   {
      var stack = new Stack<int>();

      string[] tokens = expression.Split(' ');

      foreach (string token in tokens)
      {
         if (int.TryParse(token, out int number))
         {
            stack.Push(number);
         }
         else
         {
            int b = stack.Pop();
            int a = stack.Pop();

            switch (token)
            {
               case "+":
                  stack.Push(a + b);
                  break;
               case "-":
                  stack.Push(a - b);
                  break;
               case "*":
                  stack.Push(a * b);
                  break;
               case "/":
                  stack.Push(a / b);
                  break;
               default:
                  throw new ArgumentException("Invalid operator");
            }
         }
      }
      return stack.Pop();
   }
   public static void Ex05()
   {
      try
      {
         string expr = "3 4 + 2 *"; // (3 + 4) * 2

         int result = EvaluatePostfix(expr);

         Console.WriteLine($"Result: {result}"); // result =14
      }
      catch (Exception ex)
      {
         Console.WriteLine($"Error: {ex.Message}");
      }
   }

}

class Command
{
   public string Description { get; }

   public Command(string description) => Description = description;
}

