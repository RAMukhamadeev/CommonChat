using System;
using System.Windows.Forms;

namespace CommonChat
{
    public partial class MainForm : Form
    {
        public MainForm()
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
            string queryString = "CREATE TABLE Users1 (Email varchar(255) NOT NULL PRIMARY KEY, PasswordHash varchar(255) NOT NULL, DateOfRegistration datetime NOT NULL);";
            //string queryString = "INSERT INTO Users (Email, PasswordHash) VALUES ('123@12.ru', '12323');";

            SqlLibrary.ExecuteQuery(queryString);
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
    }
}
