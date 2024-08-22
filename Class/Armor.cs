using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    

    public class Helmet
    {
        public string name;
        private float armor;

        internal float ArmorProperty
        {
            get { return armor; }
            set 
            {
                if (value > 1f)
                {
                    armor = 1f;
                    return;
                }
                if (value < 0f)
                {
                    armor = 0f;
                    return;
                }
                armor = value;
            }
        }

        public float Armor()
        {
            return armor;
        }

        public void Info()
        {
            Console.WriteLine($"Броня {name} равна: {this.armor}");
        }

        public Helmet(string name)
        {
            this.name = name;
        }

        public Helmet()
        {
            this.name = "Helm";
        }
    }


    public class Shell
    {
        public string name;
        private float armor;

        internal float ArmorProperty
        {
            get { return armor; }
            set
            {
                if (value > 1f)
                {
                    armor = 1f;
                    return;
                }
                if (value < 0f)
                {
                    armor = 0f;
                    return;
                }
                armor = value;
            }
        }

        public float Armor()
        {
            return armor;
        }

        public void Info()
        {
            Console.WriteLine($"Броня {name} равна: {this.armor}");
        }

        public Shell(string name)
        {
            this.name = name;
        }

        public Shell()
        {
            this.name = "Shell";
        }
    }


    public class Boots
    {
        public string name;
        private float armor;

        internal float ArmorProperty
        {
            get { return armor; }
            set
            {
                if (value > 1f)
                {
                    armor = 1f;
                    return;
                }
                if (value < 0f)
                {
                    armor = 0f;
                    return;
                }
                armor = value;
            }
        }

        public float Armor()
        {
            return armor;
        }

        public void Info()
        {
            Console.WriteLine($"Броня {name} равна: {this.armor}");
        }

        public Boots(string name)
        {
            this.name = name;
        }

        public Boots()
        {
            this.name = "Boots";
        }
    }


    internal class Armor
    {

    }
}
