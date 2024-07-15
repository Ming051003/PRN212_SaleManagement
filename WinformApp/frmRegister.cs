using BusinessObjects.Models;
using DataAccessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformApp
{
    public partial class frmRegister : Form
    {
        private readonly IMemberRepository memberRepository;
        public frmRegister()
        {
            InitializeComponent();
            memberRepository = new MemberRepository();
        }

        private void createAccount(object sender, EventArgs e)
        {
            if (tbEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Email is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbPassword.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!tbPassword.Text.Trim().Equals(tbRePassword.Text.Trim()))
            {
                MessageBox.Show("Password and re-password not same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Member member = new Member();
            member.Email = tbEmail.Text.Trim();
            member.City = tbCity.Text.Trim();
            member.Country = tbCountry.Text.Trim();
            member.Password = tbPassword.Text.Trim();
            member.Role = "USER";

            memberRepository.AddMember(member);
            MessageBox.Show("Register Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmLogin frmLogin = new frmLogin(); 
            this.Hide();
            frmLogin.ShowDialog();
            
        }

        private void goToLogin(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.Show();
        }
    }
}
