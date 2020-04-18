using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herogame_2
{

    public class Hero
    {
        public String name;
        private int hp;
        private int mp;
        private int power;
        private int deffence_power;
        public List<int> deffence_add = new List<int>();
        private int damage;
        public bool sacrifice;
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
            get{return this.damage;}

        }

        public Hero(String name)
        {
            this.hp = 50;
            this.power = 6;
            this.name = name;
            this.deffence_power = 3;
            this.mp = 2;
        }
        public void Attack(Slim slim)
        {
            Random a = new Random();
            attack_add = a.Next(5);
            damage = this.power + attack_add - slim.Deffence_power;
            slim.Hp = slim.Hp-damage;
           

        }

        public void Defence()
        {
            deffence_add.Add(4);
        }
        
        public void Defend_party()
        {
            sacrifice = true;
        }
    }
}
