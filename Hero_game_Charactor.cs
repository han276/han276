using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herogame_2
{
    public class Charactor
    {
        public string name;
        private int hp;
        private int mp;
        private int power;
        private int deffence_power;
        private int max_HP;
        private int max_MP;

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

        public int Max_HP
        {
            get { return this.max_HP; }
        }

        public int Max_MP
        {
            get { return this.max_MP; }
        }

        public int Power
        {
           get{ return this.power; }
        }


        public Charactor(string name,int hp,int mp, int power, int deffence_power, int max_HP, int max_MP)
        {
            this.hp = hp;
            this.mp = mp;
            this.power = power;
            this.name = name;
            this.deffence_power = deffence_power;
            this.max_HP = max_HP;
            this.max_MP = max_MP;
        }





    }
}
