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
     public partial class Form13 : Form
     {



         SqlConnection v = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\GAME OVER\Desktop\project\proj\Database1.mdf;Integrated Security=True");
          public Form13()
          {
              v.Open();
              InitializeComponent();
         
             
               
          }

        

          private void Form13_Load(object sender, EventArgs e)
          {

          }

          private void label4_Click(object sender, EventArgs e)
          {

          }

          private void gunaGradientButton7_Click(object sender, EventArgs e)
          {
              Form4 ob = new Form4();
              ob.Show();
              this.Hide();
          }

          private void gunaGradientButton8_Click(object sender, EventArgs e)
          {
              SqlCommand s = new SqlCommand("select name2 from loans where name2='"+gunaTextBox4.Text+"'",v);
              SqlDataReader f = s.ExecuteReader();

              if (f.HasRows)
              {
                  f.Close();
                  gunaTextBox1.Text = "";
                  gunaTextBox2.Text = "";
                  gunaTextBox3.Text = "";
                  gunaTextBox4.Text = "";
                  gunaTextBox5.Text = "";
                  gunaTextBox6.Text = "";
                  gunaTextBox7.Text = "";
                  MessageBox.Show("هذا الشخص يمتلك كفاله حاليه");
              }


              else
              {
                  f.Close();
                  SqlCommand j = new SqlCommand("insert into loans values('" + gunaTextBox1.Text + "','" + gunaTextBox2.Text + "'," + gunaTextBox3.Text + "," + gunaTextBox7.Text + ",'" + gunaTextBox4.Text + "','" + gunaTextBox5.Text + "'," + gunaTextBox6.Text + ",'" + label1.Text + "')", v);
                  j.ExecuteNonQuery();
                  gunaTextBox1.Text = "";
                  gunaTextBox2.Text = "";
                  gunaTextBox3.Text = "";
                  gunaTextBox4.Text = "";
                  gunaTextBox5.Text = "";
                  gunaTextBox6.Text = "";
                  gunaTextBox7.Text = "";
                  MessageBox.Show("العمليه تمت بنجاح");
              }

          }

          private void gunaTextBox2_TextChanged(object sender, EventArgs e)
          {

          }
     }
}
