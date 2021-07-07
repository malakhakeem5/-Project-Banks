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
     public partial class Form5 : Form
     {
         SqlConnection v = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\GAME OVER\Desktop\project\proj\Database1.mdf;Integrated Security=True");
          public Form5()
          {
              v.Open();
               InitializeComponent();
               gunaPanel2.Visible = false;
               dataGridView1.Visible = false;
               dataGridView2.Visible = false;
               textBox1.Visible = false;
               label2.Visible = false;
               gunaGradientButton4.Visible = false;
               dataGridView3.Visible = false;
               dataGridView4.Visible = false;
             
          }

          private void button3_Click(object sender, EventArgs e)
          {

          }

          

          private void button4_Click(object sender, EventArgs e)
          {
               
          }

     

          private void Form5_Load(object sender, EventArgs e)
          {

          }

          private void label1_Click(object sender, EventArgs e)
          {

          }

          private void gunaGradientButton1_Click(object sender, EventArgs e)
          {
              dataGridView4.Visible = false;
              dataGridView3.Visible = false;
              SqlDataAdapter d = new SqlDataAdapter("select * from User1", v);
              DataTable b = new DataTable();
              d.Fill(b);
              dataGridView1.DataSource = b;
              gunaPanel2.Visible = true;
              dataGridView1.Visible = true;
              dataGridView2.Visible = false;
              textBox1.Visible = false;
              label2.Visible = false;
              gunaGradientButton4.Visible = false;
          }

          private void gunaGradientButton2_Click(object sender, EventArgs e)
          {
              dataGridView4.Visible = false;
              dataGridView3.Visible = false;
             gunaGradientButton4.Visible = true;
             gunaPanel2.Visible = false;
             dataGridView1.Visible = false;
             dataGridView2.Visible = true;
             textBox1.Visible = true;
             label2.Visible = true;
             SqlDataAdapter d = new SqlDataAdapter("select * from User1", v);
             DataTable b = new DataTable();
             d.Fill(b);
             dataGridView2.DataSource = b;
           
          }

          private void gunaGradientButton3_Click(object sender, EventArgs e)
          {
              dataGridView1.Visible = false;
              dataGridView2.Visible = false;
              dataGridView3.Visible = true;
              dataGridView4.Visible = false;
              gunaPanel2.Visible = false;
              textBox1.Visible = false;
              label2.Visible = false;
              gunaGradientButton4.Visible = false;
             
              SqlDataAdapter d = new SqlDataAdapter("select * from loans", v);
              DataTable b = new DataTable();
              d.Fill(b);
              dataGridView3.DataSource = b;
          }

          private void gunaButton1_Click(object sender, EventArgs e)
          {
              
          }

         

         

          private void gunaGradientButton4_Click_1(object sender, EventArgs e)
          {
              SqlCommand cmd = new SqlCommand("delete from User1 where Id =" + textBox1.Text + "", v);
              cmd.ExecuteNonQuery();
              MessageBox.Show("تــم الــحذف ");
              SqlDataAdapter d = new SqlDataAdapter("select * from User1", v);
              DataTable b = new DataTable();
              d.Fill(b);
              dataGridView2.DataSource = b;
              textBox1.Text = "";
          }

          private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {

          }

          private void gunaGradientButton5_Click(object sender, EventArgs e)
          {
              Form2 f = new Form2();
              this.Hide();
              f.Show();
          }

          private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {

          }

          private void gunaGradientButton6_Click(object sender, EventArgs e)
          {
              dataGridView1.Visible = false;
              dataGridView2.Visible = false;
              dataGridView3.Visible = false;
              dataGridView4.Visible = true;
              SqlDataAdapter d = new SqlDataAdapter("select * from se", v);
              DataTable b = new DataTable();
              d.Fill(b);
              dataGridView4.DataSource = b;
          }
     }
}
