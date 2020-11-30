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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=haitao-server.database.windows.net;Initial Catalog=StudDB;User ID=Haitao;Password=WHTwht121;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter adp;
        int StudentID;
        DataTable dt = new DataTable();
        int paid_state;

        public Form2(string Username)
        {
            InitializeComponent();
            MessageBox.Show("You successfully loggin in to username: " + Username );
            this.user.Text = Username;
            firstname.Focus();
        }
     
        private void Form2_Load(object sender, EventArgs e)
        {
            DataDisplay();
        }
        private void DataDisplay()
        {
            SqlCommand Com = new SqlCommand("SELECT * FROM student_info where Username = '"+user.Text+"'", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = Com.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
        }

        private void avm_KeyUp(object sender, EventArgs e)
        {
            if (avm.Text == "" || avm.Text.Any(char.IsLetter))
            {
                avm.BackColor = System.Drawing.Color.Red;
            }
            else {
                avm.BackColor = System.Drawing.Color.White;
            }

        }

   
        public void paid_CheckedChanged(object sender, EventArgs e)
        {

            if (paid.Checked == true)
            {
                 paid_state = 1;
            }
            else
            {
                 paid_state = 0;
            }
        }

        private void add_Click( object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into student_info values(@FirstName, @LastName, @DOB, @Gender, @Paid, @AVM , @Username)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FirstName", firstname.Text);
                cmd.Parameters.AddWithValue("@LastName", lastname.Text);
                cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Gender", gender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Paid", paid_state);
                cmd.Parameters.AddWithValue("@AVM", avm.Text);
                cmd.Parameters.AddWithValue("@Username", user.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                DataDisplay();
                clear();

                
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from student_info WHERE StudentID = @inde", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@inde", StudentID);
            cmd.ExecuteNonQuery();
            con.Close();
            DataDisplay();
            clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gender.Text.ToString().Length >= 20 || gender.Text.ToString() == "")
            {
                gender.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                gender.BackColor = System.Drawing.Color.White;
            }
        }

       
        private void firstname_KeyUp(object sender, KeyEventArgs e)
        {
            if (firstname.TextLength >= 20 || firstname.Text == "")
            {
                firstname.BackColor = System.Drawing.Color.Red;
            }
            else {
                firstname.BackColor = System.Drawing.Color.White;
            }
            
        }

        private void lastname_Keyup(object sender, EventArgs e)
        {
            if (lastname.TextLength >= 20 || lastname.Text == "")
            {
                lastname.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                lastname.BackColor = System.Drawing.Color.White;
            }
        }


   
        private void update_Click(object sender, EventArgs e)
        {
            if (firstname.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update student_info set FirstName = @FirstName, LastName = @LastName, DOB = @DOB, Gender = @Gender, Paid = @Paid, AVM = @AVM ,Username =  @Username WHERE StudentID = @inde", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@inde", this.StudentID);
                cmd.Parameters.AddWithValue("@FirstName", firstname.Text);
                cmd.Parameters.AddWithValue("@LastName", lastname.Text);
                cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Gender", gender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Paid", paid_state);
                cmd.Parameters.AddWithValue("@AVM", avm.Text);
                cmd.Parameters.AddWithValue("@Username", user.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                DataDisplay();
                clear();
            }
            else 
            {
                MessageBox.Show("please select a student to update.");
            }
        }

        private void clear()
        {
            firstname.Clear();
            lastname.Clear();
            avm.Clear();
            dateTimePicker1.ResetText();
            paid.Refresh();
            gender.ResetText();
            firstname.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                StudentID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[7].Value);
                firstname.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                lastname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                avm.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                gender.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells[4].Value.ToString() == "1")
                    paid.Checked = true;
                else
                {
                    paid.Checked = false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("To select a row, please click on the first column of that row");
            }

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                adp = new SqlDataAdapter("select * from student_info where FirstName = '" + firstname.Text + "' AND LastName = '" + lastname.Text + "' ", con);
                adp.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;
                notice.Text = "notice: You need to input both firstname and lastname to find a student!";
                notice.ForeColor = System.Drawing.Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
    
}
