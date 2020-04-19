using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Herogame_2
{
    public class Healslim : Slim
    {
        
        private int heal_point;

        public int Heal_point
        {
            get { return this.heal_point; }
        }
        
        public Healslim()
            : base("ホイミスライム",70, 6, 4)
        {
            
        }

        public void Heal()
        {
            Random a = new Random();
            heal_point = a.Next(3, 7);
            this.Hp += heal_point;

        }



    }
}
