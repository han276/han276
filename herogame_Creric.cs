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
        private int hp;
        private int power;
        private int deffence_power;
        private int mp;
        private int damage;
        private int heal_point;
        private int prey_point;
        private int attack_add;
        public int Hp
        {
            get { return this.hp; }
            set { hp = value; }
        }
        public int Mp
        {
            get { return this.mp; }
            set { mp = value; }
        }
        public int Deffence_power
        {
            get { return this.deffence_power; }
        }

        public int Damage
        {
            get { return this.damage; }

        }

        public int Heal_point
        {
            get { return this.heal_point; }
        }

        public int Prey_point
        {
            get { return this.prey_point; }
        }

        public Creric(String name)
        {
            this.hp = 30;
            this.power = 2;
            this.deffence_power = 1;
            this.mp = 12;
            this.name = name;
        }

        public void Attack(Slim slim)
        {
            Random a = new Random();         
            attack_add = a.Next(5);
            damage = this.power + attack_add - slim.Deffence_power;

            if (damage > 0)
            {
                slim.Hp -= damage;
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
            h.Hp = h.Hp+heal_point;
            this.mp -= 3;
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
