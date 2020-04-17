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
        public int hp;
        public int mp;
        public int power;
        public int defence_power;
        public List<int> deffence_add = new List<int>();
        public int damage;
        public bool sacrifice;
        public Hero(String name)
        {
            this.hp = 50;
            this.power = 6;
            this.name = name;
            this.defence_power = 3;
            this.mp = 2;
        }
        public void Attack(Slim m)
        {
            Random a = new Random();
            int attack_add = a.Next(5);
            damage = this.power + attack_add - m.defence_power;
            m.hp -= damage;

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
