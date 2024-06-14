using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetologiaTest01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TryFirst();

            void TryFirst()
            {
                string s;
                Console.WriteLine("Enter two numbers in turn.");

                if (!int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.WriteLine("Not a number!");
                    YesNo();
                    return;
                }

                if (!int.TryParse(Console.ReadLine(), out int b))
                {
                    Console.WriteLine("Not a number!");
                    YesNo();
                    return;
                }

                Console.WriteLine("Enter the character for the operation.");

                switch (s = Console.ReadLine())
                {
                    case "+":
                        Console.WriteLine("Result of {0} + {1} = {2}", a, b, a + b);
                        break;
                    case "-":
                        Console.WriteLine("Result of {0} - {1} = {2}", a, b, a - b);
                        break;
                    case "*":
                        Console.WriteLine("Result of {0} * {1} = {2}", a, b, a * b);
                        break;
                    case "/":
                        Console.WriteLine("Result of {0} / {1} = {2}", a, b, a / b);
                        break;
                    case "&":
                        Console.WriteLine("Result of {0} & {1} = {2}", a, b, a & b);
                        break;
                    case "^":
                        Console.WriteLine("Result of {0} ^ {1} = {2}", a, b, a ^ b);
                        break;
                    default:
                        Console.WriteLine("Wrong sign!");
                        break;
                }
                YesNo();
            }

            void YesNo()
            {
                Console.WriteLine("Try first? (yes / no)");
                switch (Console.ReadLine())
                {
                    case "yes":
                        Console.Clear();
                        TryFirst();
                        break;
                    case "y":
                        Console.Clear();
                        TryFirst();
                        break;
                    case "no":
                        Exit();
                        break;
                    case "n":
                        Exit();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("The word \"no\" or \"yes\" was entered incorrectly. Try again.");
                        YesNo();
                        break;
                }

            }

            void Exit()
            {
                Console.WriteLine("Goodbay!");
                return;
            }
            
        }
    }
}
