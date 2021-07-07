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
     public partial class createacount : Form
     {
         SqlConnection v = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\GAME OVER\Desktop\project\proj\Database1.mdf;Integrated Security=True");
          public createacount()
          {
               v.Open();
               InitializeComponent();
          }

          private void textBox3_TextChanged(object sender, EventArgs e)
          {

          }

          private void createacount_Load(object sender, EventArgs e)
          {

          }

          private void gunaGradientButton1_Click(object sender, EventArgs e)
          {
              SqlCommand c = new SqlCommand("insert into User1 (email,password,phone) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", v);
              c.ExecuteNonQuery();

              MessageBox.Show("Create Account , Done ");

              Form4 f = new Form4();
              this.Hide();
              f.Show();
          }

          private void gunaButton1_Click(object sender, EventArgs e)
          {
              Form1 c = new Form1();
              c.Show();
              this.Hide();
          }
     }
}
