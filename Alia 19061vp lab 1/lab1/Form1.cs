namespace lab1
{
    public partial class Form1 : Form
    {
       //public  string gender;
       // public string combo;
       // public string field;
       // public string it;
       // public string cs;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            
           form.stdName = textBox2.Text;
            form.rollno= textBox1.Text;
           
            if (radioButton1.Checked== true)
            {
                form.gender = radioButton1.Text;
               
            }
            else
            {
                form.gender = radioButton2.Text;
               
            }

          
            form.combo = comboBox1.Text;
            if (checkBox1.Checked == true)
            {
                form.chechbox1 = checkBox1.Text;

            }
            else if (checkBox2.Checked == true)
            {
                form.chechbox2 =checkBox2.Text;

            }
            else if (checkBox3.Checked == true)
            {
                form.chechbox3 = checkBox3.Text;

            }
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                form.chechbox1 = checkBox1.Text;
                form.chechbox2 = checkBox2.Text;
                form.chechbox3 = checkBox3.Text;
            }


                form.ShowDialog(); 
            
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}