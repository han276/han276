using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herogame_2
{
    public class Slim
    {
        public String name;
        public int hp;
        public int power;
        public int defence_power;
        public int damage;

        public Slim(String name,int hp,int power,int defence_power)
        {
            this.hp = hp;
            this.name = name;
            this.power = power;
            this.defence_power = defence_power;
        }

        public void Attack(Hero h)
            {
            Random a = new Random();
            int attack_add = a.Next(7);
            damage = this.power + attack_add - h.defence_power - h.deffence_add.Sum();
            h.hp -= damage;
            h.deffence_add.Clear();
        }

        public void Attack(Creric c)
        {
            Random b = new Random();
            int attack_add = b.Next(7);
            damage = this.power + attack_add - c.defence_power;
            c.hp -= damage;
        }






    }
}
