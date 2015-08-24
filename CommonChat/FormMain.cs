using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;

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
        private long CurrCountOfMessages { get; set; }
        private DispatcherTimer _mainTimer;

        private void MainForm_Load(object sender, EventArgs e)
        {
            StartListening();
        }

        void StartCheckingForNewMessages()
        {
            long messages = SqlLibrary.CountOfMessages();
            if (messages > CurrCountOfMessages)
            {
                CurrCountOfMessages = messages;
                StartUpdateChat();
            }

            RefreshInfo(messages);
        }

        void mainTimer_Tick(object sender, EventArgs e)
        {
            Thread thread = new Thread(StartCheckingForNewMessages);
            thread.Start();
        }

        private void StartListening()
        {
            _mainTimer = new DispatcherTimer();
            _mainTimer.Tick += mainTimer_Tick;
            _mainTimer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            _mainTimer.Start();
        }

        private void StartUpdateChat()
        {
            Thread update = new Thread(RefreshChatControl);
            update.Start();
        }

        private void RefreshInfo(long countOfMessages)
        {
            try
            {
                BeginInvoke(new MethodInvoker(
                delegate
                {
                    if (countOfMessages >= 0)
                    {
                        lblServerStatus.Text = "Online";
                        lblServerStatus.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblServerStatus.Text = "Offline";
                        lblServerStatus.ForeColor = Color.Red;
                    }
                    gbChat.Text = String.Format("Общий чат ({0} сообщений)", countOfMessages);
                }));
            }
            catch
            {
                // ignored
            }
        }

        private void RefreshChatControl()
        {
            DataTable dt = SqlLibrary.GetAllMessages();

            try
            {
               BeginInvoke(new MethodInvoker(
               delegate
               {
                   rtbChat.Clear();
                   if (dt != null)
                   {
                       foreach (DataRow record in dt.Rows)
                       {
                           rtbChat.AppendText(record[5] + "\n");
                           rtbChat.AppendText(String.Format("{0} {1} ({2}) написал(а) : \n", record[2], record[3],
                               record[1]));
                           rtbChat.AppendText(record[4] + "\n");
                           rtbChat.AppendText("\n");
                       }
                       rtbChat.SelectionStart = rtbChat.Text.Length - 1;
                       rtbChat.SelectionLength = 0;
                   }
               }));
            }
            catch
            {
                // ignored
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
            string res = SqlLibrary.SendMessage(CurrUserEmail, CurrUserFirstName, CurrUserLastName, rtbMessage.Text);
            if (res != "")
                MessageBox.Show(res);
        }
    }
}
