using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herogame_2
{
    public class Creric:Charactor
    {
        
        private int damage;
        private int heal_point;
        private int prey_point;
        private int attack_add;        

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

        public Creric()
            :base("アサカ", 30, 12, 2, 3, 30, 12)
        {

        }

        public void Attack(Slim slim)
        {
            Random a = new Random();         
            attack_add = a.Next(5);
            damage = this.Power + attack_add - slim.Deffence_power;

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
            this.Mp -= 3;
        }

        public void Prey()
        {
            Random c = new Random();
            prey_point = c.Next(5, 10);
            this.Mp += prey_point;
        }

        public void Self_aid()
        {
            this.Hp += 5;
        }


    }
}
