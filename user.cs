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
    public partial class user : Form
    {
        SqlConnection v = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\GAME OVER\Desktop\project\proj\Database1.mdf;Integrated Security=True");
        public user()
        {
          
            v.Open();
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            this.Hide();
            f.Show();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            SqlCommand ms = new SqlCommand("Select email from User1 where password="+gunaTextBox2.Text+" and email='"+gunaTextBox1.Text+"'" , v);
            SqlDataReader fxs = ms.ExecuteReader();
            if (fxs.HasRows)
            {

                fxs.Close();
                SqlCommand m = new SqlCommand("Select money from se where name='" + gunaTextBox1.Text + "'", v);
                string q = m.ExecuteScalar().ToString();
                int x = int.Parse(q);
                int y = int.Parse(gunaTextBox4.Text);
                if (x < y)
                {
                    MessageBox.Show("Your balance is not enough ");
                }
                else
                {
                    SqlCommand mx = new SqlCommand("Select name from se where name='" + gunaTextBox3.Text + "'", v);
                    SqlDataReader fx = mx.ExecuteReader();
                    if (fx.HasRows)
                    {
                        fx.Close();
                        int z = x + y;
                        int p = x - y;
                        SqlCommand cmd = new SqlCommand("update se set money =" + z + "  where name='" + gunaTextBox3.Text + "'", v);
                        cmd.ExecuteNonQuery();
                        SqlCommand cm = new SqlCommand("update se set money =" + p + "  where name='" + gunaTextBox1.Text + "' ", v);
                        cm.ExecuteNonQuery();
                        gunaTextBox2.Text = "";
                        gunaTextBox3.Text = "";
                        gunaTextBox4.Text = "";
                        MessageBox.Show("The operation was completed successfully");
                    }
                    else
                    {
                        fx.Close();
                        MessageBox.Show("There is no account with this name");
                    }
                }
            }

            else
            {
                fxs.Close();
                MessageBox.Show("Your password  or your name is uncorect");
                gunaTextBox2.Text = "";
            }
        }
    }
}
