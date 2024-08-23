using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class
{
    public class Unit
    {
        private float _health;
        private float _baseDamage = 5f;
        private Weapon _weapon;
        private Helm _helm;
        private Shell _shell;
        private Boots _boots;
        private bool _weaponEquip = false;
        private bool _helmEquip = false;
        private bool _shellEquip = false;
        private bool _bootsEquip = false;
        private float _weaponDamage;

        public string Name { get; }

        public float Health => _health;

        public float Damage
        {
            get
            {
                if (_weaponEquip)
                {
                    return _baseDamage + _weaponDamage; // возвращаем сумму базового урона и урона от оружия если оно есть
                }
                else { return _baseDamage; }
            }
            set { _weaponDamage = value; } // принимаем урон от оружия в переменную WeaponDamag
        }

        public float Armor
        {
            get
            {
                
                float value = _helm.Armor + _shell.Armor + _boots.Armor;
                if (value > 1f)
                {
                    return 1f;
                }
                else if (value < 0f)
                {
                    return 0f;
                }
                else
                {
                    value = (float)Math.Round(value, 2);
                    return value; 
                }

            }
        }

        public Unit(string name)
        {
            Name = name;
        }

        public Unit(float health, string name = "Unknown Unit") : this(name)
        {
            _health = health;
        }

        public Unit() : this("Unknown Unit")
        {
        }

        public float RealHealth() { return Health * (1f + Armor); }

        public bool SetDamage(float damage)
        {
            _health = Health - damage * Armor;

            if (Health <= 0f)
            {
                return true;
            }
            else { return false; }
        }

        public void EquipWeapon(Weapon weapon) // Снарядить Weapon | Замена оружия на новое
        {
            _weaponEquip = true;
            _weapon = weapon;
            Console.WriteLine($"{_weapon.Name} - экипировано!");
        }

        public void EquipHelm(Helm helm) // Снарядить Helm
        {
            _helmEquip = true;
            _helm = helm;
            Console.WriteLine($"{_helm.Name} - экипировано!");
        }

        public void EquipShell(Shell shell) // Снарядить Shell
        {
            _shellEquip = true;
            _shell = shell;
            Console.WriteLine($"{_shell.Name} - экипировано!");
        }

        public void EquipBoots(Boots boots) // Снарядить Boots
        {
            _bootsEquip = true;
            _boots = boots;
            Console.WriteLine($"{_boots.Name} - экипировано!");
        }

        public void Info()
        {
            Console.WriteLine($"{Name}, {_health}, {Armor}, {RealHealth()}");
        }
    }
}
