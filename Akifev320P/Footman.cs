using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akifev320P
{
    internal class Footman : Unit
    {
        private int _damage;

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public Footman() : base(60, "Footman")
        {
            _damage = 7;
        }

        public void InflictDamage(Unit unit)
        {
            if (unit.isAlive)
            {
                unit.Health -= _damage;
            }
            else
            {
                Console.WriteLine("impossible - Unit is dead");
            }

        }
    }
}
