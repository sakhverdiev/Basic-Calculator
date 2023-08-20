using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   class Program
   {
       static void Main(string[] args)
       {
           double num1, num2;
           char op;
           double result;

           Console.Write("Enter first number: ");
           num1 = Convert.ToDouble(Console.ReadLine());

           Console.Write("Enter second number: ");
           num2 = Convert.ToDouble(Console.ReadLine());

           Console.Write("Enter operation (+,-,*,/): ");
           op = Convert.ToChar(Console.ReadLine());

           if (op == '+')
           {
               result = num1 + num2;
           }
           else if (op == '-')
           {
               result = num1 - num2;
           }
           else if (op == '*')
           {
               result = num1 * num2;
           }
           else if (op == '/')
           {
               if (num2 != 0)
               {
                   result = num1 / num2;
               }
               else
               {
                   Console.WriteLine("Cannot divide by zero!");
                   return; // Exit
               }
           }
           else
           {
               Console.WriteLine("Invalid operation!");
               return; // Exit
           }

           Console.WriteLine($"{num1} {op} {num2} = {result}");
       }
   }
}