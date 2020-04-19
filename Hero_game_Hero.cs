using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herogame_2
{

    public class Hero:Charactor
        
    {     
        public List<int> deffence_add = new List<int>();
        private int damage;
        public bool sacrifice;
        private int attack_add;
        public int Damage
        {
            get{return this.damage;}

        }

        public Hero()
            :base("ミナト", 50, 5, 6, 3, 50, 5)
        {                     
          
        }
        public void Attack(Slim slim)
        {
            Random a = new Random();
            attack_add = a.Next(5);
            damage = this.Power + attack_add - slim.Deffence_power;
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
