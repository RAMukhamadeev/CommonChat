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

        private void MainForm_Load(object sender, EventArgs e)
        {
            // тестовые запросы
            //string queryString = "CREATE TABLE Persons (PersonID int NOT NULL PRIMARY KEY, LastName varchar(255), FirstName varchar(255));";
            //string queryString = "INSERT INTO Persons (PersonID, LastName, FirstName) VALUES (777, 'Very', 'Cool');";
            //string queryString = "SELECT * FROM Persons;";

            // запросы для создания структуры БД
            //string queryString = "CREATE TABLE Users1 (Email varchar(255) NOT NULL PRIMARY KEY, PasswordHash varchar(255) NOT NULL, DateOfRegistration datetime NOT NULL);";
            //string queryString = "INSERT INTO Users (Email, PasswordHash) VALUES ('123@12.ru', '12323');";
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
            if (dt == null || dt.Rows.Count == 0)
                MessageBox.Show("Вход не выполнен :(");
            else
            {
                tbPassword.Text = "";
                tbEmail.Text = "";
                gbLogin.Visible = false;

                lblUser.Text = String.Format("{0} {1} ({2})", dt.Rows[0].ItemArray[2], dt.Rows[0].ItemArray[3], dt.Rows[0].ItemArray[0]);
            }
        }
    }
}
