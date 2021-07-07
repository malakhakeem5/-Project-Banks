using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proj
{
     public partial class Form2 : Form
     {
         SqlConnection v = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\GAME OVER\Desktop\project\proj\Database1.mdf;Integrated Security=True");
      
          public Form2()
          {
               InitializeComponent();
               v.Open();
          }


          private void Form2_Load(object sender, EventArgs e)
          {

          }

          private void groupBox1_Enter(object sender, EventArgs e)
          {

          }

          private void gunaGradientButton1_Click(object sender, EventArgs e)
          {
              SqlCommand mxs = new SqlCommand("Select password from AdminT where email='" + textBox1.Text + "' and password='" + textBox2.Text + "'", v);
              SqlDataReader f = mxs.ExecuteReader();

              if (f.HasRows)
              {
                  this.Hide();
                  Form5 no = new Form5();
                  no.Show();

              }
                  
         else
                  {
               f.Close();

              SqlCommand cmd = new SqlCommand("Select email from User1 where email='" + textBox1.Text + "' and password=" + textBox2.Text + "", v);
              string name=cmd.ExecuteScalar().ToString();
              SqlDataReader s = cmd.ExecuteReader();

              if (s.HasRows)
              {
                  
                  this.Hide();
                  Form4 no = new Form4();
                  no.name = name;
                  no.Show();
                

              }
                  else
              {
                  s.Close();
                  MessageBox.Show("please check your Password and Username...");
              }
                  }

              
          }

          private void gunaButton1_Click(object sender, EventArgs e)
          {
              Form1 f = new Form1();
              this.Hide();
              f.Show();
          }
     }
} 