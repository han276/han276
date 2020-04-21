using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herogame_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public Hero h = new Hero();
        public Creric c = new Creric();
        public Slim m = new Slim("スライム",50,5,3);
        public Slim m1 = new Slim("キングスライム", 100, 10, 5);
        public Healslim m2 = new Healslim();
        Slim[] slims = new Slim[4];
        Charactor[] Charactors = new Charactor[2];
        public Save_load save_Load = new Save_load();
        
        int i;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            comboBox2.Enabled = true;
            human_picture.ImageLocation = @"C:\herogame_picture\hero.bmp";
            int index = comboBox1.SelectedIndex;
            switch(index)
            {
                case 0:
                    Random r = new Random();
                    int rr = r.Next(4);

                    if (rr != 0)
                    {
                        h.Attack(slims[i]);
                        textBox1.Text = (h.name + "は" + slims[i].name + "に" + h.Damage.ToString() + "のダメージを与えた！");
                    }
                    else if(rr == 0)
                    {
                        h.Great_attack(slims[i]);
                        textBox1.Text = ("会心の一撃！" + h.name + "は" + slims[i].name + "に" + h.Damage.ToString() + "のダメージを与えた！");
                    }
                        break;
                case 1:
                    h.Defence();
                    textBox1.Text=(h.name + "は守りを固めた！");
                    break;
                case 2:
                    h.Defend_party();
                    break;
            }

            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
            timer2.Enabled = true;
            human_picture.ImageLocation= @"C:\herogame_picture\creric.bmp";
            int index = comboBox2.SelectedIndex;
            switch (index)
            {
                case 0:
                    c.Attack(slims[i]);
                    textBox1.Text=(c.name + "は" + slims[i].name + "に" + c.Damage.ToString() + "のダメージを与えた！");
                    break;
                case 1:
                    c.Heal(h);
                    textBox1.Text=(c.name + "はホイミを唱えた!"+h.name + "はHPが" + c.Heal_point.ToString() + "回復！");
                    break;
                case 2:
                    c.Prey();
                    textBox1.Text=(c.name + "は神に祈りを捧げた！"+c.name + "はMPが" + c.Prey_point.ToString() + "回復！");
                    break;
                case 3:
                    c.Self_aid();
                    textBox1.Text=(c.name + "はHPが5回復！");
                    break;
            }
          
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int g = 0; g < Charactors.Length; g++)
            {
                if (Charactors[g].Hp > Charactors[g].Max_HP)
                {
                    Charactors[g].Hp = Charactors[g].Max_HP;
                }
                if (Charactors[g].Mp > Charactors[g].Max_MP)
                {
                    Charactors[g].Mp = Charactors[g].Max_MP;
                }
            }
            label4.Text = h.Hp.ToString();
            label6.Text = h.Mp.ToString();
            label9.Text = c.Hp.ToString();
            label10.Text = c.Mp.ToString();
            label11.Text = slims[i].name;
            label12.Text = slims[i].Hp.ToString();
            label14.Text = h.name;
            label15.Text = c.name;
            experience_label.Text = h.Experience.Sum().ToString();

            if (slims[i].Hp <= 0)
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                timer2.Enabled = false;
                monstor_picture.Image = null;
                timer1.Enabled = false;
            }



        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            comboBox1.Enabled = true;
            System.Threading.Thread.Sleep(3000);


            if (h.sacrifice == true)
            {
                slims[i].Attack(h);
                
                textBox1.Text=(h.name+"は" + c.name + "をかばった！"+" " +slims[i].name + "は" + h.name + "に" + slims[i].Damage.ToString() + "のダメージを与えた！");
                h.sacrifice = false;

            }
            else if((i==0)||(i==1))
            {
                Random a = new Random();
                int index = a.Next(1, 3);

                switch (index)
                {
                    case 1:
                        slims[i].Attack(h);
                        textBox1.Text=(slims[i].name + "は" + h.name + "に" + slims[i].Damage.ToString() + "のダメージを与えた！");
                        break;
                    case 2:
                        slims[i].Attack(c);
                        textBox1.Text=(slims[i].name + "は" + c.name + "に" + slims[i].Damage.ToString() + "のダメージを与えた！");
                        break;
                }
            }
            else if(i==2)
            {
                Random b = new Random();
                int index = b.Next(1, 4);

                switch (index)
                {
                    case 1:
                        slims[i].Attack(h);
                        textBox1.Text = (slims[i].name + "は" + h.name + "に" + slims[i].Damage.ToString() + "のダメージを与えた！");
                        break;
                    case 2:
                        slims[i].Attack(c);
                        textBox1.Text = (slims[i].name + "は" + c.name + "に" + slims[i].Damage.ToString() + "のダメージを与えた！");
                        break;
                    case 3:
                        m2.Heal();
                        textBox1.Text = (slims[i].name + "はホイミを唱えた！" +m2.Heal_point.ToString()+"回復した！");
                        break;
                }
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
            timer2.Enabled = false;
            slims[0] = m;
            slims[1] = m1;
            slims[2] = m2;
            Charactors[0] = h;
            Charactors[1] = c;

            Bitmap bitmap = new Bitmap(@"C:\herogame_picture\background.bmp");
            this.BackgroundImage = bitmap;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void buttle_start_Click(object sender, EventArgs e)
        {
            buttle_start.Enabled = false;
            Random a = new Random();
            i = a.Next(0, 3);
            comboBox1.Enabled = true;
            timer1.Enabled = true;
            timer3.Enabled = true;
            slims[0].Hp = 50;
            slims[1].Hp = 100;
            slims[2].Hp = 70;

            switch(i)
            {
                case 0:
                    monstor_picture.ImageLocation = @"C:\herogame_picture\slim.bmp";
                    break;
                case 1:
                    monstor_picture.ImageLocation = @"C:\herogame_picture\kingslim.bmp";
                    break;
                case 2:
                    monstor_picture.ImageLocation = @"C:\herogame_picture\healslim.bmp";
                    break;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (slims[i].Hp <= 0)
            {
                timer3.Enabled = false;
                textBox1.Text = "勇者たちは" + slims[i].name + "を倒した！";
                slims[i].Defeated();
                if (slims[i].defeated == true)
                {
                    switch (i)
                    {
                        case 0:
                            h.Experience.Add(5);
                            break;
                        case 1:
                            h.Experience.Add(16);
                            break;
                        case 2:
                            h.Experience.Add(10);
                            break;

                    }
                }
                slims[i].defeated = false;
                buttle_start.Enabled = true;
            }
        }

        private void record_Click(object sender, EventArgs e)
        {
            save_Load.Save(h);
            textBox1.Text = "データをセーブしました";
        }

        private void load_Click(object sender, EventArgs e)
        {
            save_Load.Load(h);
            textBox1.Text = "データをロードしました";
        }
    }
}
