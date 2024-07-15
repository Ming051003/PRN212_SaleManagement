using Repositories;

namespace WinformApp
{
    public partial class frmLogin : Form
    {
        private readonly IMemberRepository repository;
        public frmLogin()
        {
            InitializeComponent();
            repository = new MemberRepository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text;
            string password = txtPassword.Text;
            var account = repository.CheckLogin(email, password);

            if (account == null)
            {
                MessageBox.Show("Wrong email or password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(account.Role == "USER")
            {
                frmCreateOrder frmCreateOrder = new frmCreateOrder();
                this.Hide();
                frmCreateOrder.ShowDialog();

                
            }else if(account.Role == "ADMIN")
            {
                frmMain frmMain = new frmMain();
                this.Hide();
                frmMain.ShowDialog();
                
            }
            

        }
        public void ClearMember()
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearMember();
        }

        private void goToRegister(object sender, MouseEventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            this.Hide();
            frmRegister.ShowDialog();
        }
    }
}
