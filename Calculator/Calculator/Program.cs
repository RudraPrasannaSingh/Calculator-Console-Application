using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   class Program
   {
      static void Main(string[] args)
      {// Display a welcome message.
         Console.WriteLine("Welcome to the calculator!");

         // Get the first number from the user.
         Console.WriteLine("Enter the first number:");
         string firstNumberString = Console.ReadLine();
         int firstNumber = Convert.ToInt32(firstNumberString);

         // Get the second number from the user.
         Console.WriteLine("Enter the second number:");
         string secondNumberString = Console.ReadLine();
         int secondNumber = Convert.ToInt32(secondNumberString);

         // Display the menu.
         Console.WriteLine("What operation would you like to perform?");
         Console.WriteLine("1. Addition");
         Console.WriteLine("2. Subtraction");
         Console.WriteLine("3. Multiplication");
         Console.WriteLine("4. Division");

         // Get the user's choice.
         Console.WriteLine("Enter your choice:");
         string choiceString = Console.ReadLine();
         int choice = Convert.ToInt32(choiceString);

         // Perform the operation.
         switch (choice)
         {
            case 1:
               Console.WriteLine("The sum is: " + (firstNumber + secondNumber));
               break;
            case 2:
               Console.WriteLine("The difference is: " + (firstNumber - secondNumber));
               break;
            case 3:
               Console.WriteLine("The product is: " + (firstNumber * secondNumber));
               break;
            case 4:
               Console.WriteLine("The quotient is: " + (firstNumber / secondNumber));
               break;
            default:
               Console.WriteLine("Invalid choice.");
               break;
         }

         // Wait for a key press.
         Console.ReadKey();
      }
   }
}
