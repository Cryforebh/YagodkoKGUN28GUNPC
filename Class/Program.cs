using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class
{

    public class Weapon // Класс оружия
    {
        private string _name;
        private float _damage;
        private float _minDamage;
        private float _maxDamage;

        internal string NameProperty
        {
            set { _name = value; }
        }

        internal float DamageProperty
        {
            get { return _damage; }
        }

        internal float MinDamagePropery
        {
            set { _minDamage = value; }
        }

        internal float MaxDamagePropery
        {
            set { _maxDamage = value; }
        }

        public Weapon(string name)
        {
            this._name = name;
        }

        public Weapon(string name, float minDamage, float maxDamage)
        {
            this._name = name;
            SetDamageParams(minDamage, maxDamage);
        }

        public Weapon()
        {
            this._name = "AK-74";
        }

        public void SetDamageParams(float minDamage, float maxDamage)
        {
            if(minDamage > maxDamage)
            {
                Console.WriteLine($"Некорректные входные данные {_name}!");
            }
            if(minDamage < 1f)
            {
                this._minDamage = 1f;
                Console.WriteLine($"Форсированная установка минимального значения урона");
            }
            if (maxDamage <= 1f)
            {
                this._maxDamage = 10f;
            }
        }

        public float GetDamage()
        {
            return (this._minDamage + this._maxDamage)/2;
        }
    }



    public class Unit // Класс персонажа
    {
        private string _name;
        private float _health;
        private float _damage = 5f;
        private float _fullDamage;
        private float _armor;
        private bool _weapon = true;

        // Свойства.............................................................

        internal string NameProperty // Принимаем имя
        {
            set { _name = value; }
        }

        internal float HealthProperty // Уровень здоровья
        { 
            get { return _health; }
            set 
            { 
                if (value < 10f)
                {
                    _health = 10f;
                    return;
                }
                if (value > 100f)
                {
                    _health = 100f;
                    return;
                }
                _health = value;
            }
        }

        internal float DamageProperty // Базовый урон плюс урон от оружия
        {
            get { return _damage; }
            set 
            {
                if (_weapon)
                {
                    _fullDamage = _damage + value;
                    return;
                }
            }
        }

        internal float ArmorProperty
        {
            get { return _armor; }
            
            set 
            {
                _armor += (float)Math.Round(value, 2); // Округленная сумма всей защиты из классов разной части брони

                if (_armor < 0f)
                {
                    _armor = 0f;
                    return;
                }

                if (_armor > 1f)
                {
                    _armor = 1f;
                    return;
                }
            }
        }

        // Методы ......................................................................

        public float Armor() // Общая броня
        {
            return _armor;
        }

        public float RealHealth() // Фактическое здоровье
        {
            return _health * (1f + _armor);
        }

        public bool SetDamage(bool dead) // Получить урон
        {
            _health = _health - _damage * _armor;

            if (_health > 0f)
            {
                dead = false;
                return dead;
            }
            if (_health <= 0f)
            {
                dead = true;
                return dead;
            }
            return dead;
        }

        public void EquipWeapon(Weapon weapon) // Снарядить оружие
        {
            Weapon weaponTwo = new Weapon("Weapon02");
            weapon = weaponTwo;
            Console.WriteLine("Орудие заменено на новое.");
        }

        public void EquipWeapon(Helmet helmet) // Снарядить шлем
        {
            Helmet Two = new Helmet();
            Two.name = "Helm02";
            helmet = Two;
        }

        public void EquipWeapon(Shell shell) // Снарядить доспех
        {
            Shell Two = new Shell();
            Two.name = "Shell02";
            shell = Two;
        }

        public void EquipWeapon(Boots boots) // Снарядить ботинки
        {
            Boots Two = new Boots();
            Two.name = "Boots02";
            boots = Two;
        }

        public void InfoName()
        {
            Console.WriteLine($"\nПерсонаж: {this._name}\n");
        }

        public Unit(string name)
        {
            this._name = name;
        }

        public Unit()
        {
            this._name = "Unknown Unit";
        }

    }



    internal class Program
    {

        static void Main(string[] args)
        {
            Unit unit = new Unit();
            Helmet helmet = new Helmet();
            Shell shell = new Shell();  
            Boots boots = new Boots();
            Weapon weapon = new Weapon();

            Console.WriteLine("Подготовка к бою!\n");

            Console.Write("Введите имя бойца: ");
            unit.NameProperty = Console.ReadLine();


            Console.Write("Введите начальное здоровье бойца (10-100): ");
            unit.HealthProperty = float.Parse(Console.ReadLine());


            Console.Write("Введите значение брони шлема от 0, до 1: ");          
            helmet.ArmorProperty = float.Parse(Console.ReadLine());
            unit.ArmorProperty = helmet.Armor();

            Console.Write("Введите значение брони кирасы от 0, до 1: ");
            shell.ArmorProperty = float.Parse(Console.ReadLine());
            unit.ArmorProperty = shell.Armor();

            Console.Write("Введите значение брони сапог от 0, до 1: ");
            boots.ArmorProperty = float.Parse(Console.ReadLine());
            unit.ArmorProperty = boots.Armor();

            Console.Write("Укажите минимальный урон оружия (0-20): ");
            weapon.MinDamagePropery = float.Parse(Console.ReadLine());

            Console.Write("Укажите максимальный урон оружия (20-40): ");
            weapon.MaxDamagePropery = float.Parse(Console.ReadLine());

            Console.WriteLine($"Общий показатель брони равен: {unit.Armor()}");

            Console.WriteLine($"Фактическое значение здоровья равно: {unit.RealHealth()}");



        }

    }





}
