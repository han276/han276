using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herogame_2
{
    public class Slim
    {
        public string name;
        private int hp;
        private int power;
        private int deffence_power;
        private int damage;
        private int attack_add;
        
        public int Hp
        {
            get { return this.hp; }
            set { hp = value; }
        }

        public int Damage
        {
            get { return this.damage; }

        }

        public int Deffence_power
        {
            get { return this.deffence_power; }
        }


        public Slim(string name,int hp,int power,int deffence_power)
        {
            this.hp = hp; 
            this.name = name;
            this.power = power;
            this.deffence_power = deffence_power;
        }

        public void Attack(Hero h)
        {     
            Random a = new Random();
            attack_add = a.Next(7);
            damage = this.power + attack_add - h.Deffence_power - h.deffence_add.Sum();
            h.Hp -= damage;
            h.deffence_add.Clear();
        }

        public void Attack(Creric c)
        {
            Random b = new Random();
            int attack_add = b.Next(7);
            damage = this.power + attack_add - c.Deffence_power;
            c.Hp -= damage;
        }






    }
}
