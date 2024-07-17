using BusinessObjects.Models;
using Repositories;
using System.Data;

namespace WinformApp
{
    public partial class frmMember : Form
    {
        private readonly IMemberRepository memberRepository;
        public frmMember()
        {
            InitializeComponent();
            memberRepository = new MemberRepository();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter an email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var member = new Member();
            //member.MemberId = int.Parse(txtId.Text);
            //if (memberRepository.GetAllMembers().Where(m => m.MemberId.Equals(member.MemberId)).FirstOrDefault() != null)
            //{
            //    MessageBox.Show("Member ID already exists. Please enter a different ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtId.Focus(); // Đặt focus lại vào textbox email để người dùng nhập lại
            //    return;
            //}

            member.Email = txtEmail.Text.Trim();
            if (memberRepository.GetAllMembers().Where(m => m.Email.Equals(member.Email)).FirstOrDefault() != null)
            {
                MessageBox.Show("Email already exists. Please enter a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus(); // Đặt focus lại vào textbox email để người dùng nhập lại
                return;
            }

            member.City = txtCity.Text.Trim();
            member.Country = txtCountry.Text.Trim();
            member.Password = "1";
            member.Role = "USER";

            memberRepository.AddMember(member);
            MessageBox.Show("Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInfor();
            LoadMember();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text != null && txtEmail.Text != null)
            {

                int memberID;
                if (int.TryParse(txtId.Text, out memberID))
                {
                    Member member = memberRepository.GetMemberById(memberID);
                    member.Email = txtEmail.Text.Trim();
                    //if (memberRepository.GetAllMembers().Where(m => m.Email.Equals(member.Email)).FirstOrDefault() != null)
                    //{
                    //    MessageBox.Show("Email already exists. Please enter a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    txtEmail.Focus(); // Đặt focus lại vào textbox email để người dùng nhập lại
                    //    return;
                    //}
                    member.City = txtCity.Text.Trim();
                    member.Country = txtCountry.Text.Trim();
                    member.Role = txtRole.Text.Trim();
                    member.Password = "1";
                    memberRepository.UpdateMember(member);
                    MessageBox.Show("Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearInfor();
                    LoadMember();
                }
                else
                {
                    MessageBox.Show("Member ID is empty. Please choose a different ID.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            string keyword = tbSearch.Text.Trim().ToLower();
            var list = memberRepository.GetAllMembers().Where(m => m.Email.ToLower().Contains(keyword))
                .Select(m => new
                {
                    Id = m.MemberId,
                    Email = m.Email,
                    Role = m.Role,
                    City = m.City,
                    Country = m.Country,
                }).ToList();
            dgvMemberList.DataSource = list;
        }


        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            int memberID;
            if (int.TryParse(txtId.Text, out memberID))
            {
                if (memberID != null)
                {
                    if (MessageBox.Show("Do you want to delete it?", "Warning", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        memberRepository.DeleteMember(memberID);
                    }
                    else
                    {
                        return;
                    }
                }
                ClearInfor();
                LoadMember();
            }
            else
            {
                MessageBox.Show("Member ID is empty. Please choose a different ID.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void clickCellShowInfo(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var rowSelected = this.dgvMemberList.Rows[e.RowIndex];
                txtId.Text = rowSelected.Cells["Id"].Value.ToString();
                txtEmail.Text = rowSelected.Cells["Email"].Value.ToString();
                txtRole.Text = rowSelected.Cells["Role"].Value.ToString();
                txtCity.Text = rowSelected.Cells["City"].Value.ToString();
                txtCountry.Text = rowSelected.Cells["Country"].Value.ToString();
            }

            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;

        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            LoadMember();
        }

        public void LoadMember()
        {
            dgvMemberList.DataSource = memberRepository.GetAllMembers().Select(m => new
            {
                Id = m.MemberId,
                Email = m.Email,
                Role = m.Role,
                City = m.City,
                Country = m.Country,
            }).ToList();
        }
        public void ClearInfor()
        {
            txtId.Text = "";
            txtEmail.Text = "";
            txtRole.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInfor();
        }
    }
}
