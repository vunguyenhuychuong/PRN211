using BussinessObject;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmLogin : System.Windows.Forms.Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var adminLogin = Program.Configuration.GetSection("AdminAccount").Get<MemberObject>();
            var memberLogin = Program.Configuration.GetSection("MemberAccount").Get<MemberObject>();

            string Email = adminLogin.Email;
            string EmailMember = memberLogin.Email;

            string Password = adminLogin.Password;
            string PasswordMember = memberLogin.Password;

            string _Email = txtEmail.Text;
            string _Password = txtPassword.Text;
            string _EmailMember = txtEmail.Text;
            string _PasswordMember = txtPassword.Text;

            if(Email.Equals(_Email) && Password.Equals(_Password))
            {
                MessageBox.Show("Login successfully with role admin");
                frmMemberManagement frmMemberManagement = new frmMemberManagement(_Email);
                frmMemberManagement.Show();
                this.Hide();
            }

            else if(EmailMember.Equals(_EmailMember) && PasswordMember.Equals(_PasswordMember))
            {
                MessageBox.Show("login successfully with role member");
            }
            else
            {
                MessageBox.Show("login failllll");
            }

            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmail.ResetText();
            txtPassword.ResetText();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
