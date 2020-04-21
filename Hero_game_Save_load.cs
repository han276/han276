using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herogame_2
{
    public class Save_load
    {
        public string data;
        public Save_load()
        {

        }

        public void Save(Hero c)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\herogame_picture\data.txt", false, System.Text.Encoding.Default);
            sw.WriteLine(c.Experience.Sum().ToString());
            sw.Close();
            
        }
        public void Load(Hero c)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(@"C:\herogame_picture\data.txt", System.Text.Encoding.Default);
            string load_data;
            load_data = sr.ReadLine();
            sr.Close();
            c.Experience.Add(Convert.ToInt32(load_data));
        }

    }
}
