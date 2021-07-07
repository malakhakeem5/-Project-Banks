using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          private void button5_Click(object sender, EventArgs e)
          {
             

          }

         
          private void button3_Click(object sender, EventArgs e)
          {
          }

          private void Form1_Load(object sender, EventArgs e)
          {

          }

          private void gunaButton1_Click(object sender, EventArgs e)
          {
              Form2 ff = new Form2();
              ff.Show();
              ff.Location = this.Location;
              this.Hide();
          }

          private void gunaButton2_Click(object sender, EventArgs e)
          {
              createacount ff = new createacount();
              ff.Show();
              this.Hide();
          }

        
     }
}
