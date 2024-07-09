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

            if (account != null)
            {
                MessageBox.Show("Login Successful !!");
            }
            else
            {
                MessageBox.Show("Wrong email or password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e) => Application.Exit();

        private void goToRegister(object sender, MouseEventArgs e)
        {

        }
    }
}
