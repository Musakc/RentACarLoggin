using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using RentACarLoggin.BusinessLayer;
using RentACarLoggin.DataAccessLayer;
using System.Security;

namespace RentACarLoggin
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.ActiveControl = txtUserN;
            
        }
        static string constring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RentAcar0;Integrated Security=True;";
        SqlConnection connect = new SqlConnection(constring);
        private void Form3_Load(object sender, EventArgs e)
        {
          
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {


        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUserN.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

    
        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {

                txtPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {

                txtPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
         
        }
        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            try
            {
                if ( string.IsNullOrWhiteSpace(txtUserN.Text) ||
                     string.IsNullOrWhiteSpace(txtPassword.Text) ||
                     string.IsNullOrWhiteSpace(txtConfirmPassword.Text) ||
                     string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                     string.IsNullOrWhiteSpace(txtName.Text) ||
                     string.IsNullOrWhiteSpace(txtSurname.Text) || 
                     string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
                string Email = txtEmail.Text;

               
                if (!Email.EndsWith("@gmail.com" ) && !string.IsNullOrWhiteSpace(Email))
                {
                    
                    MessageBox.Show("Lütfen geçerli bir Gmail e-posta adresi girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                var userService = new UserServiceform3(new UserRepository(constring));
                userService.RegisterUser(txtUserN.Text, txtPassword.Text, txtConfirmPassword.Text, txtPhoneNumber.Text, txtName.Text, txtSurname.Text);
                MessageBox.Show("Kayıt eklendi");
                this.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata meydana geldi: " + hata.Message);
            }


            string username = txtUserN.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;


            if (password == confirmPassword)
            {

                MessageBox.Show("Kayıt başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);


               this.Close();
            }
            else
            {
                MessageBox.Show("Şifreler eşleşmiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string email = txtEmail.Text;
 
        } 

        private void txtName_TextChanged(object sender, EventArgs e)
        {
         
        }
        private void txtName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void chkShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            bool showPassword = chkShowPassword.Checked;
            txtPassword.UseSystemPasswordChar = !showPassword;
            txtConfirmPassword.UseSystemPasswordChar = !showPassword;
        }

        private void Form3_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
    

        }

        private void txtUserN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
                 
        }

        }

        }
   