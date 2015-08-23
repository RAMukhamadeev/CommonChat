using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonChat
{
    public partial class FormSqlConsole : Form
    {
        public FormSqlConsole()
        {
            InitializeComponent();
        }

        private void btnSendQuery_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader sdr = SqlLibrary.ExecuteQuery(rtbQuery.Text);
            }
            catch
            {
                rtbSqlResponse.AppendText("Произошла ошибка при обработке SQL запроса");
            }
            
        }
    }
}
