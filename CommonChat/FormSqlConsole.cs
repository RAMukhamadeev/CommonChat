using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace CommonChat
{
    public partial class FormSqlConsole : Form
    {
        public FormSqlConsole()
        {
            InitializeComponent();
        }

        private void SendQuery()
        {
            DataTable dt = null;
            bool isError = false;
            try
            {
                dt = SqlLibrary.ExecuteQuery(rtbQuery.Text);
            }
            catch (Exception ex)
            {
                rtbSqlResponse.AppendText("Произошла ошибка при обработке SQL запроса :( \n");
                rtbSqlResponse.AppendText(ex.Message + "\n");
                isError = true;
            }

            if (!isError)
            {
                rtbSqlResponse.AppendText("Запрос выполнен успешно! :) \n");
                if (dt != null)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                            rtbSqlResponse.AppendText(dt.Rows[i].ItemArray[j] + " ");
                        rtbSqlResponse.AppendText("\n");
                    }
                }
            }
        }

        private void btnSendQuery_Click(object sender, EventArgs e)
        {
            SendQuery();
        }
    }
}
