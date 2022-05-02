using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form2 : Form
    {
        public string stdName { get; set; }
       public string rollno { get; set; }
        public string gender { get; set; }
        
        public string combo{ get; set; }
        public string chechbox1 { get; set; }
        public string chechbox2 { get; set; }
        public string chechbox3 { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = stdName;
           label2.Text = rollno;
            label6.Text = gender;
            label7.Text = combo;
            label9.Text = chechbox1;
            label10.Text = chechbox2;
            label11.Text = chechbox3;


        }
    }
}
