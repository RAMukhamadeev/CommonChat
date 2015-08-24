namespace CommonChat
{
    partial class FormSqlConsole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbQuery = new System.Windows.Forms.RichTextBox();
            this.btnSendQuery = new System.Windows.Forms.Button();
            this.rtbSqlResponse = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbQuery
            // 
            this.rtbQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbQuery.Location = new System.Drawing.Point(12, 28);
            this.rtbQuery.Name = "rtbQuery";
            this.rtbQuery.Size = new System.Drawing.Size(1109, 154);
            this.rtbQuery.TabIndex = 0;
            this.rtbQuery.Text = "";
            // 
            // btnSendQuery
            // 
            this.btnSendQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendQuery.Location = new System.Drawing.Point(12, 758);
            this.btnSendQuery.Name = "btnSendQuery";
            this.btnSendQuery.Size = new System.Drawing.Size(1109, 90);
            this.btnSendQuery.TabIndex = 1;
            this.btnSendQuery.Text = "Отправить запрос";
            this.btnSendQuery.UseVisualStyleBackColor = true;
            this.btnSendQuery.Click += new System.EventHandler(this.btnSendQuery_Click);
            // 
            // rtbSqlResponse
            // 
            this.rtbSqlResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSqlResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbSqlResponse.Location = new System.Drawing.Point(12, 212);
            this.rtbSqlResponse.Name = "rtbSqlResponse";
            this.rtbSqlResponse.Size = new System.Drawing.Size(1109, 499);
            this.rtbSqlResponse.TabIndex = 2;
            this.rtbSqlResponse.Text = "";
            // 
            // FormSqlConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1133, 869);
            this.Controls.Add(this.rtbSqlResponse);
            this.Controls.Add(this.btnSendQuery);
            this.Controls.Add(this.rtbQuery);
            this.Name = "FormSqlConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Консоль для SQL команд";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbQuery;
        private System.Windows.Forms.Button btnSendQuery;
        private System.Windows.Forms.RichTextBox rtbSqlResponse;
    }
}