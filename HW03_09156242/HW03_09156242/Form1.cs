using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW03_09156242
{
    public partial class Form1 : Form
    {
        double second;
        int index = 0;
        List<CheckBox> pictures = new List<CheckBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void apply(object sender, EventArgs e)
        {
            Boolean k = true;
            if (timer1.Enabled == true)
                timer1.Stop();

            if (textBox1.Text.Equals(""))
            {
                second = 1.0;
                k = false;
            }
            else
                second = Convert.ToDouble(textBox1.Text);

            pictures.Clear();
            check_and_add();
            timer1.Interval = (int)(second * 1000);
            if(pictures.Count > 0 && k)
                timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String name = "movie_00" + pictures[index].Tag;
            display_box.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(name);
            if (index + 1 == pictures.Count())
                index = 0;
            else
                index++;
        }

        void check_and_add()
        {
            if (checkBox1.Checked == true)
                pictures.Add(checkBox1);
            if (checkBox2.Checked == true)
                pictures.Add(checkBox2);
            if (checkBox3.Checked == true)
                pictures.Add(checkBox3);
            if (checkBox4.Checked == true)
                pictures.Add(checkBox4);
            if (checkBox5.Checked == true)
                pictures.Add(checkBox5);
        }
    }
}
