using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{

    public partial class Form4 : Form
    {
        SqlConnection v = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\GAME OVER\Desktop\project\proj\Database1.mdf;Integrated Security=True");
        public string name;

        public Form4()
        {
            v.Open();
            InitializeComponent();
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            dewi f = new dewi();
            this.Hide();
            f.Show();
            
        }

       
        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
               
            }

      

        private void button6_Click(object sender, EventArgs e)
        {
            user f = new user();
            f.gunaTextBox1.Text = name;
            this.Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       

        private void button7_Click(object sender, EventArgs e)
        {
            Form13 ob = new Form13();
            ob.label1.Text = "company";
            ob.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form13 ob = new Form13();
            ob.label1.Text = "defult";
            ob.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            Form13 ob = new Form13();
            ob.label1.Text = "Projects";
            ob.Show();
            this.Hide();
        }

       

       

        

        }
    }


     

