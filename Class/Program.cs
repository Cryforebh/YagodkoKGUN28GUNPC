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
        static void FormulaUnitFloat(string text, float oneValue, float twoValue, float result)
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

            float health;

            do
            {
                Console.Write($"\nВведите начальное здоровье бойца (10-100): ");

                if (!float.TryParse(Console.ReadLine(), out float value))
                {
                    Console.WriteLine("Укажите цифры!");
                    health = value;
                }
                else
                {
                    health = value;
                }

            }
            while (health > 100f || health < 10f);

            //...............................................................................

            var unit = new Unit(health, name);

            //...............................................................................

            float armorHelm;

            do
            {
                Console.Write($"\nВведите значение брони шлема от 0, до 1: ");

                if (!float.TryParse(Console.ReadLine(), out float value))
                {
                    Console.WriteLine("Укажите цифры!");
                    armorHelm = -1f;
                }
                else
                {
                    armorHelm = value;
                }

            }
            while (armorHelm > 1f || armorHelm < 0f);

            //...............................................................................

            float armorShell;

            do
            {
                Console.Write($"\nВведите значение брони кирасы от 0, до 1: ");

                if (!float.TryParse(Console.ReadLine(), out float value))
                {
                    Console.WriteLine("Укажите цифры!");
                    armorShell = -1f;
                }
                else
                {
                    armorShell = value;
                }

            }
            while (armorShell > 1f || armorShell < 0f);

            //...............................................................................

            float armorBoots;

            do
            {
                Console.Write($"\nВведите значение брони сапог от 0, до 1: ");

                if (!float.TryParse(Console.ReadLine(), out float value))
                {
                    Console.WriteLine("Укажите цифры!");
                    armorBoots = -1f;
                }
                else
                {
                    armorBoots = value;
                }

            }
            while (armorBoots > 1f || armorBoots < 0f);

            //...............................................................................

            var helm = new Helm(armorHelm);
            var shell = new Shell(armorShell);
            var boots = new Boots(armorBoots);

            //...............................................................................

            float minDamage;

            do
            {
                Console.Write($"\nУкажите минимальный урон оружия (0-20): ");

                if (!float.TryParse(Console.ReadLine(), out float value))
                {
                    Console.WriteLine("Укажите цифры!");
                    minDamage = -1f;
                }
                else
                {
                    minDamage = value;
                }

            }
            while (minDamage > 20f || minDamage < 0f);

            //...............................................................................

            float maxDamage;

            do
            {
                Console.Write($"\nУкажите максимальный урон оружия (20-40): ");

                if (!float.TryParse(Console.ReadLine(), out float value))
                {
                    Console.WriteLine("Укажите цифры!");
                    maxDamage = value;
                }
                else
                {
                    maxDamage = value;
                }

            }
            while (maxDamage > 40f || maxDamage < 20f);

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
