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
using System.Data.Sql;

namespace RentACarLoggin.UserForm
{
   
    public partial class Form4 : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            
        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {

                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {

                txtPassword.UseSystemPasswordChar = true;
            }
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            Form3 form3geçiş = new Form3();
            form3geçiş.Show();

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RentAcar0;Integrated Security=True;"))
            {
                string query = "SELECT * FROM Bilgi WHERE kullanici_adi = @username AND sifre = @password";
                using (SqlCommand com = new SqlCommand(query, con))
                {
                    com.Parameters.AddWithValue("@username", username);
                    com.Parameters.AddWithValue("@password", password);

                    con.Open();
                    using (SqlDataReader dr = com.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            MessageBox.Show("Giriş başarılı");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Hatalı kullanıcı adı veya şifre");
                        }
                    }
                }
            }
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {

                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {

                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            Form3 form3geçiş = new Form3();
            form3geçiş.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form4 = new Form1();
            form4.Show();
        }
    }
}
