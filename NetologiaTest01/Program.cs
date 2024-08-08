using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetologiaTest01_Сalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number one:");

            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Not a number!");
                return;
            }

            Console.WriteLine("Enter number two:");

            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Not a number!");
                return;
            }

            Console.WriteLine("Enter sign:");

            var result = 0;
            string userInput = Console.ReadLine();

            switch (userInput?[0])
            {
                case '+':
                    result = a + b; 
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;
                case '%':
                    result = a % b;
                    break;
                case '&':
                    result = a & b;
                    break;
                case '|':
                    result = a | b;
                    break;
                case '^':
                    result = a ^ b;
                    break;
                default:
                    Console.WriteLine("Error! Wrong sign!");
                    break;
            }

            Console.WriteLine($"Result of {a} {userInput?[0]} {b} = {result}");
            Console.WriteLine($"Binary system (2): Result of {a} {userInput?[0]} {b} = {Convert.ToString(value: result, toBase: 2)}");
            Console.WriteLine($"Decimal system (10): Result of {a} {userInput?[0]} {b} = {result}");
            Console.WriteLine($"Hexadecimal system (16): Result of {a} {userInput?[0]} {b} = {Convert.ToString(value: result, toBase: 16)}");







            //TryFirst();

            //void TryFirst()
            //{
            //    string s;
            //    Console.WriteLine("Enter two numbers in turn.");

            //    if (!int.TryParse(Console.ReadLine(), out int a))
            //    {
            //        Console.WriteLine("Not a number!");
            //        YesNo();
            //        return;
            //    }

            //    if (!int.TryParse(Console.ReadLine(), out int b))
            //    {
            //        Console.WriteLine("Not a number!");
            //        YesNo();
            //        return;
            //    }

            //    Console.WriteLine("Enter the character for the operation.");

            //    switch (s = Console.ReadLine())
            //    {
            //        case "+":
            //            Console.WriteLine("Result of {0} + {1} = {2}", a, b, a + b);
            //            Console.WriteLine("In binary: "); 
            //            Console.WriteLine(Convert.ToString(a + b, 2));
            //            Console.WriteLine("In hexadecimal: ");
            //            Console.WriteLine(Convert.ToString(a + b, 16));
            //            break;
            //        case "-":
            //            Console.WriteLine("Result of {0} - {1} = {2}", a, b, a - b);
            //            Console.WriteLine("In binary: ");
            //            Console.WriteLine(Convert.ToString(a - b, 2));
            //            Console.WriteLine("In hexadecimal: ");
            //            Console.WriteLine(Convert.ToString(a - b, 16));
            //            break;
            //        case "*":
            //            Console.WriteLine("Result of {0} * {1} = {2}", a, b, a * b);
            //            Console.WriteLine("In binary: ");
            //            Console.WriteLine(Convert.ToString(a * b, 2));
            //            Console.WriteLine("In hexadecimal: ");
            //            Console.WriteLine(Convert.ToString(a * b, 16));
            //            break;
            //        case "/":
            //            Console.WriteLine("Result of {0} / {1} = {2}", a, b, a / b);
            //            Console.WriteLine("In binary: ");
            //            Console.WriteLine(Convert.ToString(a / b, 2));
            //            Console.WriteLine("In hexadecimal: ");
            //            Console.WriteLine(Convert.ToString(a / b, 16));
            //            break;
            //        case "&":
            //            Console.WriteLine("Result of {0} & {1} = {2}", a, b, a & b);
            //            Console.WriteLine("In binary: ");
            //            Console.WriteLine(Convert.ToString(a & b, 2));
            //            Console.WriteLine("In hexadecimal: ");
            //            Console.WriteLine(Convert.ToString(a & b, 16));
            //            break;
            //        case "^":
            //            Console.WriteLine("Result of {0} ^ {1} = {2}", a, b, a ^ b);
            //            Console.WriteLine("In binary: ");
            //            Console.WriteLine(Convert.ToString(a ^ b, 2));
            //            Console.WriteLine("In hexadecimal: ");
            //            Console.WriteLine(Convert.ToString(a ^ b, 16));
            //            break;
            //        default:
            //            Console.WriteLine("Wrong sign!");
            //            break;
            //    }
            //    YesNo();
            //}

            //void YesNo()
            //{
            //    Console.WriteLine("Try first? (yes / no)");
            //    switch (Console.ReadLine())
            //    {
            //        case "yes":
            //            Console.Clear();
            //            TryFirst();
            //            break;
            //        case "y":
            //            Console.Clear();
            //            TryFirst();
            //            break;
            //        case "no":
            //            Exit();
            //            break;
            //        case "n":
            //            Exit();
            //            break;
            //        default:
            //            Console.Clear();
            //            Console.WriteLine("The word \"no\" or \"yes\" was entered incorrectly. Try again.");
            //            YesNo();
            //            break;
            //    }

            //}

            //void Exit()
            //{
            //    Console.WriteLine("Goodbay!");
            //    return;
            //}


        }
    }
}
