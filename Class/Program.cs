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
        static void Main(string[] args)
        {
            var templat = new Templates();

            Console.WriteLine($"Подготовка к бою!");

            //...............................................................................

            Console.Write($"Введите имя бойца: ");
            string name = Console.ReadLine();

            //...............................................................................

            float health = 0;
            templat.LimitParametersInput("\nВведите начальное здоровье бойца (10-100): ", 100f, 10f, ref health);

            //...............................................................................

            var unit = new Unit(health, name);

            //...............................................................................

            float armorHelm = 0;
            templat.LimitParametersInput("\nВведите значение брони шлема от 0, до 1: ", 1f, 0f, ref armorHelm);

            float armorShell = 0;
            templat.LimitParametersInput("\nВведите значение брони кирасы от 0, до 1: ", 1f, 0f, ref armorShell);

            float armorBoots = 0;
            templat.LimitParametersInput("\nВведите значение брони сапог от 0, до 1: ", 1f, 0f, ref armorBoots);

            //...............................................................................

            var helm = new Helm(armorHelm);
            var shell = new Shell(armorShell);
            var boots = new Boots(armorBoots);

            //...............................................................................

            float minDamage = 0;
            templat.LimitParametersInput("\nУкажите минимальный урон оружия (0-20): ", 20f, 0f, ref minDamage);

            //...............................................................................

            float maxDamage = 0;
            templat.LimitParametersInput("\nУкажите максимальный урон оружия (20-40): ", 40f, 20f, ref maxDamage);

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

            Console.WriteLine($"Экипировано: {weapons.Name}, {helm.Name}, {shell.Name}, {boots.Name}.");
        }

    }


}
