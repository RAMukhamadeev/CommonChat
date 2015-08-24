using System;
using System.Windows.Forms;

namespace CommonChat
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            string res = SqlLibrary.RegistrationOfNewUser(tbEmail.Text, tbPassword.Text, tbFirstName.Text, tbLastName.Text);
            MessageBox.Show(res);
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
