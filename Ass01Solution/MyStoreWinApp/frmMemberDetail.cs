using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessObject;

namespace MyStoreWinApp
{
    public partial class frmMemberDetail : Form
    {
        public frmMemberDetail()
        {
            InitializeComponent();
        }

        public bool InsertOrUpdate { get; internal set; }
        public IMemberRepository MemberRepository { get; internal set; }

        public MemberObject MemberInfo { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var mem = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Password = txtPassword.Text,
                    RoleID = txtRoleID.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Email = txtEmail.Text
                };
                if(InsertOrUpdate == false)
                {
                    MemberRepository.InsertMemberObject(mem);
                    MessageBox.Show("Addsuccefully!");
                    this.Close();
                }
                else
                {
                    MemberRepository.UpdateMemberObject(mem);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a members" : "Update a member");
            }
        }// end btnSave_Click

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
