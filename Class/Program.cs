using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class
{

    internal class Program
    {
        /// <summary>
        /// Позволяет упростить логические ньюансы.
        /// </summary>
        /// <param name="text">Выводимый в консоль текст</param>
        /// <param name="oneValue">Максимальное значение</param>
        /// <param name="twoValue">Минимальное значение</param>
        /// <param name="result">Результат ввода ( Console.ReadLine() )</param>
        static void FormulaConsole(string text, float oneValue, float twoValue, float result)
        {
            float relust;

            do
            {
                Console.Write($"{text}");

                if (!float.TryParse(Console.ReadLine(), out float value))
                {
                    Console.WriteLine("Укажите цифры!");
                    relust = -1f;
                }
                else
                {
                    relust = value;
                }

            }
            while (relust > oneValue || relust < twoValue);

        }


        static void Main(string[] args)
        {
            Console.WriteLine($"Подготовка к бою!");

            //...............................................................................

            Console.Write($"Введите имя бойца: ");
            string name = Console.ReadLine();

            //...............................................................................

            float health = 0;
            FormulaConsole("\nВведите начальное здоровье бойца (10-100): ", 100f, 10f, health);

            //...............................................................................

            var unit = new Unit(health, name);

            //...............................................................................

            float armorHelm = 0;
            FormulaConsole("\nВведите значение брони шлема от 0, до 1: ", 1f, 0f, armorHelm);

            float armorShell = 0;
            FormulaConsole("\nВведите значение брони кирасы от 0, до 1: ", 1f, 0f, armorShell);

            float armorBoots = 0;
            FormulaConsole("\nВведите значение брони сапог от 0, до 1: ", 1f, 0f, armorBoots);

            //...............................................................................

            var helm = new Helm(armorHelm);
            var shell = new Shell(armorShell);
            var boots = new Boots(armorBoots);

            //...............................................................................

            float minDamage = 0;
            FormulaConsole("\nУкажите минимальный урон оружия (0-20): ", 20f, 0f, minDamage);

            //...............................................................................

            float maxDamage = 0;
            FormulaConsole("\nУкажите максимальный урон оружия (20-40): ", 40f, 20f, maxDamage);

            //...............................................................................

            var weapons = new Weapon(minDamage, maxDamage);

            //...............................................................................

            Console.WriteLine("\nСнаряжаюсь...");

            unit.EquipHelm(helm);
            unit.EquipShell(shell); 
            unit.EquipBoots(boots);
            unit.EquipWeapon(weapons);

            //...............................................................................

            Console.WriteLine($"\nОбщий показатель брони равен: {unit.Armor}");

            //...............................................................................

            Console.WriteLine($"Фактическое значение здоровья равно: {unit.RealHealth()}");

            //...............................................................................

            Console.WriteLine($"Средний урон из {weapons.Name}: {weapons.GetDamage()}");

            //...............................................................................

            Console.WriteLine($"Экиперованно: {weapons.Name}, {helm.Name}, {shell.Name}, {boots.Name}.");
        }

    }

}
