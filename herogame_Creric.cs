using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herogame_2
{
    public class Creric
    {
        public String name;
        public int hp;
        public int power;
        public int defence_power;
        public int mp;
        public int damage;
        public int heal_point;
        public int prey_point;

        public Creric(String name)
        {
            this.hp = 30;
            this.power = 2;
            this.defence_power = 1;
            this.mp = 12;
            this.name = name;
        }

        public void Attack(Slim m)
        {
            Random a = new Random();         
            int attack_add = a.Next(5);
            damage = this.power + attack_add - m.defence_power;

            if (damage > 0)
            {
                m.hp -= damage;
            }
            else
            {
                damage = 0;
            }
        }

        public void Heal(Hero h)
        {
            Random b = new Random();
            heal_point = b.Next(5,10);
            h.hp += heal_point;
        }

        public void Prey()
        {
            Random c = new Random();
            prey_point = c.Next(5, 10);
            this.mp += prey_point;
        }

        public void Self_aid()
        {
            this.hp += 5;
        }


    }
}
