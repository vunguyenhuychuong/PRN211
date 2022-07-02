using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;
using BussinessObject;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        IMemberRepository memberRepository  = new MemberRepository();
        //Create a data source
        BindingSource source;
        //-------------------------------

        public frmMemberManagement(string Email)
        {
            InitializeComponent();
            lbEmail.Text = Email;
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;

            dgvMemberList.CellDoubleClick += DgvMemList_CellDoubleClick;
        }

        private void DgvMemList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail
            {
                Text = "Update member",
                InsertOrUpdate = true,
                MemberInfo = GetMemberObject(),
                MemberRepository = memberRepository,
            };
            if(frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                //Set focus member update
                source.Position = source.Count - 1;
            }
        }


        //private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        //clear text on TextBoxes
        private void ClearText()
        {
            txtMemberID.Text = string.Empty;
            txtMemberName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtRoleID.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtEmail_.Text = string.Empty;
        }

        private void LoadMemberList()
        {
            var members = memberRepository.GetMembers();
            try
            {
                //
                BindingSource source = new BindingSource();
                source.DataSource = members;

                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtRoleID.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtEmail_.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtRoleID.DataBindings.Add("Text", source, "RoleID");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtEmail_.DataBindings.Add("Text", source, "Email");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                if(members.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }



        private void btnClose_Click_1(object sender, EventArgs e) => Close();

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var mem = GetMemberObject();
                memberRepository.DeleteMemberObject(mem.MemberID);
                LoadMemberList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }

        private MemberObject GetMemberObject()
        {
            MemberObject mem = null;
            try
            {
                mem = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Password = txtPassword.Text,
                    RoleID = txtRoleID.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Email = txtEmail_.Text

                };
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return mem;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail
            {
                Text = "Add a new Members",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            if(frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                //set focus member insert
                source.Position = source.Count - 1;
            }
        }

        private void lbEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtTypeSearchMemberID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTypeSearchMemberID.Text))
            {
                string value = txtTypeSearchMemberID.Text;
                var members = memberRepository.GetMembers();
                List<MemberObject> memberList = new List<MemberObject>();

                LoadMemberList();

                foreach(MemberObject member in members)
                {
                    if(member.MemberID == int.Parse(value.ToString()))
                    {
                        memberList.Add(member);
                    }
                }
                if(memberList.Count <= 0)
                {
                    MessageBox.Show("Not found Member by ID");
                }
                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = memberList;
            }
            else
            {
                LoadMemberList();
            }
            
        }

        private void txtTypeSearchMemberName_TextChanged(object sender, EventArgs e)
        {
            var members = memberRepository.GetMembers();
            string nameMember = txtTypeSearchMemberName.Text;
            Console.WriteLine("=======" + nameMember);
            List<MemberObject> memberList = new List<MemberObject>();

            foreach (MemberObject member in members)
            {
                LoadMemberList();

                if (member.MemberName.ToString().ToLower().Contains(nameMember.ToLower())){
                    memberList.Add(member);
                }

            }
            if(memberList == null)
            {
                MessageBox.Show("The member is not available!!!");
            }
            dgvMemberList.DataSource = null;
            dgvMemberList.DataSource = memberList;
        }
    }
}
