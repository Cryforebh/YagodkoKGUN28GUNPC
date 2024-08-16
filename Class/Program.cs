using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static string FNO(string family, string name, string otchestvo)
        {
            return $"{family} {name} {otchestvo}";
        }

        static void Main(string[] args)
        {

            Console.Write("Введите кол-во человек: ");

            if (int.TryParse(Console.ReadLine(), out int index))
            {

                string[] stringFamily = new string[index];
                string[] stringName = new string[index];
                string[] stringOtchestvo = new string[index];

                string result;

                Console.WriteLine("");

                for (int i = 0; i < index; i++)
                {
                    Console.Write($"({i + 1}) Фамилия: ");
                    stringFamily[i] = Console.ReadLine();

                    Console.Write($"({i + 1}) Имя: ");
                    stringName[i] = Console.ReadLine();

                    Console.Write($"({i + 1}) Отчество: ");
                    stringOtchestvo[i] = Console.ReadLine();

                    Console.WriteLine("\n=================");
                }

                for (int i = 0; i < index; i++)
                {
                    Console.WriteLine($"\n({i + 1}) {result = FNO(stringFamily[i], stringName[i], stringOtchestvo[i])}");
                }

                Console.ReadLine();

            }
            else {
                Console.WriteLine("No!");
                Console.ReadLine();
            }
        }
    }
}
