using System;
using System.Data;
using System.Windows.Forms;

namespace CommonChat
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private string CurrUserEmail { get; set; }
        private string CurrUserFirstName { get; set; }
        private string CurrUserLastName { get; set; }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshChat();
        }

        private void RefreshChat()
        {
            rtbChat.Clear();
            DataTable dt = SqlLibrary.GetAllMessages();
            if (dt != null)
            {
                foreach (DataRow record in dt.Rows)
                {
                    rtbChat.AppendText(record[1].ToString() + " в " + record[3].ToString() + " написал : \n");
                    rtbChat.AppendText(record[2].ToString() + "\n");
                    rtbChat.AppendText("\n");
                }
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void консольДляSQLКомандToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSqlConsole formSqlConsole = new FormSqlConsole();
            formSqlConsole.Show();
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = SqlLibrary.Login(tbEmail.Text, tbPassword.Text);
            if (dt == null || dt.Rows.Count != 1)
                MessageBox.Show("Вход не выполнен :(");
            else
            {
                tbPassword.Text = "";
                tbEmail.Text = "";
                gbLogin.Visible = false;
                gbSendMessage.Enabled = true;

                CurrUserEmail = dt.Rows[0].ItemArray[0].ToString();
                CurrUserFirstName = dt.Rows[0].ItemArray[2].ToString();
                CurrUserLastName = dt.Rows[0].ItemArray[3].ToString();

                lblUser.Text = String.Format("{0} {1} ({2})", CurrUserFirstName, CurrUserLastName, CurrUserEmail);
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            string res = SqlLibrary.SendMessage(CurrUserEmail, rtbMessage.Text);
            if (res != "")
                MessageBox.Show(res);
        }
    }
}
