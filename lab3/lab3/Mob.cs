using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal abstract class Mob
    {
        private int hp;
        private int damage;
        private int price;

        public virtual void Attack()
        {
            Console.WriteLine("I'm Attack");
        }
    }
}
