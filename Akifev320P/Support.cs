using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Akifev320P
{
    internal class Support : Unit
    {
        private int _manna;
        public Support() : base(35, "Support")
        {
            _manna = 30;
        }
        public int Manna
        {
            get { return _manna; }
            set { _manna = value; }
        }

        public void selfHeal()
        {
            while (Manna >= 3)
            {
                Health += 5;
                Manna -= 3;
            }
        }

        public void Heal(Unit unit)
        {
            if (unit.isAlive)
            {
                while (Manna >= 5)
                {
                    unit.Health += 10;
                    Manna -= 5;
                }
            }
            else
            {
                Console.WriteLine("Object is dead");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health} Manna: {Manna}");

        }

    }
}
