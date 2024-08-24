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
            Console.WriteLine($"Подготовка к бою!");

            //...............................................................................

            Console.Write($"Введите имя бойца: ");
            string name = Console.ReadLine();

            //...............................................................................

            Templates.LimitParametersInput("\nВведите начальное здоровье бойца (10-100): ", 100f, 10f, out float health);

            //...............................................................................

            var unit = new Unit(health, name);

            //...............................................................................

            Templates.LimitParametersInput("\nВведите значение брони шлема от 0, до 1: ", 1f, 0f, out float armorHelm);

            Templates.LimitParametersInput("\nВведите значение брони кирасы от 0, до 1: ", 1f, 0f, out float armorShell);

            Templates.LimitParametersInput("\nВведите значение брони сапог от 0, до 1: ", 1f, 0f, out float armorBoots);

            //...............................................................................

            var helm = new Helm(armorHelm);
            var shell = new Shell(armorShell);
            var boots = new Boots(armorBoots);

            //...............................................................................

            Templates.LimitParametersInput("\nУкажите минимальный урон оружия (0-20): ", 20f, 0f, out float minDamage);

            //...............................................................................

            Templates.LimitParametersInput("\nУкажите максимальный урон оружия (20-40): ", 40f, 20f, out float maxDamage);

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
