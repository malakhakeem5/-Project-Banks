using System;
using System.Collections.Generic;
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
    public partial class dewi : Form
    {
        SqlConnection v = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\GAME OVER\Desktop\project\proj\Database1.mdf;Integrated Security=True");
        public dewi()
        {
            InitializeComponent();
            v.Open();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            SqlCommand mxs = new SqlCommand("Select password from User1 where email='" + gunaTextBox1.Text + "' and password='" + gunaTextBox2.Text + "'", v);
            SqlDataReader f = mxs.ExecuteReader();

            if (f.HasRows)
            {
                f.Close();
                if (gunaComboBox1.Text == "deposit")
                {

                    SqlCommand m = new SqlCommand("Select name from se where name='" + gunaTextBox1.Text + "'", v);
                    SqlDataReader fx = m.ExecuteReader();
                    if (fx.HasRows)
                    {
                        fx.Close();
                        SqlCommand mxe = new SqlCommand("Select money from se where name='" + gunaTextBox1.Text + "'", v);
                        string qe = mxe.ExecuteScalar().ToString();
                        int xe = int.Parse(qe);
                        int ye = int.Parse(gunaTextBox3.Text);
                        int ze = ye + xe;

                        SqlCommand cmdd = new SqlCommand("update se set money =" + ze + " where name='" + gunaTextBox1.Text + "' ", v);
                        cmdd.ExecuteNonQuery();
                        gunaTextBox1.Text = "";
                        gunaTextBox2.Text = "";
                        gunaTextBox3.Text = "";
                        MessageBox.Show("done");

                    }
                    else
                    {
                        fx.Close();
                        SqlCommand daa = new SqlCommand("insert into se values('" + gunaTextBox1.Text + "'," + gunaTextBox3.Text + ",'" + gunaComboBox1.Text + "') ", v);
                        daa.ExecuteNonQuery();
                        gunaTextBox1.Text = "";
                        MessageBox.Show("Done");
                    }


                }


                else if (gunaComboBox1.Text == "Withdrawal")
                {
                    SqlCommand ms = new SqlCommand("Select name from se where name='" + gunaTextBox1.Text + "'", v);
                    SqlDataReader fxs = ms.ExecuteReader();
                    if (fxs.HasRows)
                    {
                        fxs.Close();
                        SqlCommand mxes = new SqlCommand("Select money from se where name='" + gunaTextBox1.Text + "'", v);
                        string qes = mxes.ExecuteScalar().ToString();
                        int xes = int.Parse(qes);
                        int yes = int.Parse(gunaTextBox3.Text);
                        if (xes < yes)
                        {
                            MessageBox.Show("you dont have money");
                        }
                        else
                        {
                            int zes = xes - yes;
                            SqlCommand cmdds = new SqlCommand("update se set money =" + zes + " ,type='" + gunaComboBox1.Text + "' where name='" + gunaTextBox1.Text + "'", v);
                            cmdds.ExecuteNonQuery();
                            gunaTextBox1.Text = "";
                            gunaTextBox2.Text = "";
                            gunaTextBox3.Text = "";
                            MessageBox.Show("done");
                        }
                    }
                    else
                    {
                        fxs.Close();
                        MessageBox.Show("you dont have account");
                    }

                }
            }

            else
            {
                f.Close();
                MessageBox.Show("your name or password is uncorect");
                gunaTextBox1.Text = "";
                gunaTextBox2.Text = "";
                gunaTextBox3.Text = "";

            }
        }

        private void gunaGradientButton7_Click(object sender, System.EventArgs e)
        {
            Form4 f = new Form4();
            this.Hide();
            f.Show();
        }
    }
}
