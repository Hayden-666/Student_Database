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

namespace StudentDatabaseCS
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=haitao-server.database.windows.net;Initial Catalog=StudDB;User ID=Haitao;Password=WHTwht121;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int len1 = Username.Text.Length;
            if (len1 > 20)
            {
                MessageBox.Show("Your username needs to be less than 20 characters");
            }//auto validation username
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlDataAdapter adp1 = new SqlDataAdapter("select Pin From login_info where Username = '" + Username.Text + "' ", connection);
                DataTable dt1 = new DataTable();
                adp1.Fill(dt1);
                if (dt1.Rows.Count >= 1)
                {
                    MessageBox.Show("this username already existed");
                }
                else
                {
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into login_info values( '" + Username.Text + "','" + Pin.Text + "')";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    if (label5.ForeColor == System.Drawing.Color.Red || label6.ForeColor == System.Drawing.Color.Red)
                    {
                        MessageBox.Show("Please change your password");
                        Pin.Clear();
                        Pin.Focus();
                    }
                    else
                    {
                        MessageBox.Show("successful registration!!!");
                        Username.Clear();
                        Pin.Clear();
                        Username.Focus();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("registration failed!");
            }
            finally
            {

            }
        }

        private void Pin_KeyUp(object sender, EventArgs e)
        {
            var len = Pin.Text.Length;
            if (!(Pin.Text.Any(char.IsUpper) && Pin.Text.Any(char.IsLower) && Pin.Text.Any(char.IsDigit)))
            {
                label5.ForeColor = System.Drawing.Color.Red;
                label5.Text = "* Your pass word must include Uppercase, lowercase and number";
            }
            if (Pin.Text.Any(char.IsUpper) && Pin.Text.Any(char.IsLower) && Pin.Text.Any(char.IsDigit))
            {
                label5.ForeColor = System.Drawing.Color.LightGreen;
                label5.Text = "Valid security";
            }
            if (!(len <= 20 && len >= 10))
            {
                label6.ForeColor = System.Drawing.Color.Red;
                label6.Text = "* the length of yourpassword must between 10 and 20 ";
            }
            if (len <= 20 && len >= 10)
            {
                label6.ForeColor = System.Drawing.Color.LightGreen;
                label6.Text = " Valid length ";
            }


            //auto validation password
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlDataAdapter adp2 = new SqlDataAdapter("select Username From login_info WHERE Username = '" + Username.Text + "' AND Pin = '" + Pin.Text + "' ", connection);
            DataTable dt2 = new DataTable();
            adp2.Fill(dt2);
            if (dt2.Rows.Count >= 1)
            {
                Form2 frm = new Form2(Username.Text);
                frm.Show();
                this.Hide();
                //this.Close();

            }
            else
            {
                MessageBox.Show("the username or password is incorrect, please try again");
                Username.Clear();
                Pin.Clear();
                Username.Focus();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    label3.Text = "Connected";
                    label3.ForeColor = Color.Green;

                }
                else
                {
                    label3.Text = "Not Connected";
                    label3.ForeColor = Color.Red;
                }
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    } 
    }

