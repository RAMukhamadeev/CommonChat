namespace CommonChat
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.консольДляSQLКомандToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.lblServerStatusSign = new System.Windows.Forms.Label();
            this.lblUserSign = new System.Windows.Forms.Label();
            this.lblServerStatus = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.gbChat = new System.Windows.Forms.GroupBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.gbSendMessage = new System.Windows.Forms.GroupBox();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.menuStripMain.SuspendLayout();
            this.gbChat.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.gbSendMessage.SuspendLayout();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.инструментыToolStripMenuItem,
            this.действиеToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1779, 40);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(83, 36);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(180, 36);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.консольДляSQLКомандToolStripMenuItem});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // консольДляSQLКомандToolStripMenuItem
            // 
            this.консольДляSQLКомандToolStripMenuItem.Name = "консольДляSQLКомандToolStripMenuItem";
            this.консольДляSQLКомандToolStripMenuItem.Size = new System.Drawing.Size(365, 36);
            this.консольДляSQLКомандToolStripMenuItem.Text = "Консоль для SQL команд";
            this.консольДляSQLКомандToolStripMenuItem.Click += new System.EventHandler(this.консольДляSQLКомандToolStripMenuItem_Click);
            // 
            // действиеToolStripMenuItem
            // 
            this.действиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистрацияToolStripMenuItem});
            this.действиеToolStripMenuItem.Name = "действиеToolStripMenuItem";
            this.действиеToolStripMenuItem.Size = new System.Drawing.Size(132, 36);
            this.действиеToolStripMenuItem.Text = "Действие";
            // 
            // регистрацияToolStripMenuItem
            // 
            this.регистрацияToolStripMenuItem.Name = "регистрацияToolStripMenuItem";
            this.регистрацияToolStripMenuItem.Size = new System.Drawing.Size(244, 36);
            this.регистрацияToolStripMenuItem.Text = "Регистрация";
            this.регистрацияToolStripMenuItem.Click += new System.EventHandler(this.регистрацияToolStripMenuItem_Click);
            // 
            // rtbChat
            // 
            this.rtbChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbChat.Location = new System.Drawing.Point(25, 42);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.ReadOnly = true;
            this.rtbChat.Size = new System.Drawing.Size(730, 814);
            this.rtbChat.TabIndex = 1;
            this.rtbChat.Text = "";
            // 
            // rtbMessage
            // 
            this.rtbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMessage.Location = new System.Drawing.Point(23, 45);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(817, 159);
            this.rtbMessage.TabIndex = 2;
            this.rtbMessage.Text = "";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSendMessage.Location = new System.Drawing.Point(23, 226);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(817, 61);
            this.btnSendMessage.TabIndex = 3;
            this.btnSendMessage.Text = "Отправить сообщение";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // lblServerStatusSign
            // 
            this.lblServerStatusSign.AutoSize = true;
            this.lblServerStatusSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblServerStatusSign.Location = new System.Drawing.Point(38, 150);
            this.lblServerStatusSign.Name = "lblServerStatusSign";
            this.lblServerStatusSign.Size = new System.Drawing.Size(202, 29);
            this.lblServerStatusSign.TabIndex = 4;
            this.lblServerStatusSign.Text = "Статус сервера :";
            // 
            // lblUserSign
            // 
            this.lblUserSign.AutoSize = true;
            this.lblUserSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserSign.Location = new System.Drawing.Point(38, 49);
            this.lblUserSign.Name = "lblUserSign";
            this.lblUserSign.Size = new System.Drawing.Size(58, 29);
            this.lblUserSign.TabIndex = 5;
            this.lblUserSign.Text = "Вы :";
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.AutoSize = true;
            this.lblServerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblServerStatus.Location = new System.Drawing.Point(253, 150);
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(95, 29);
            this.lblServerStatus.TabIndex = 6;
            this.lblServerStatus.Text = "<none>";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser.Location = new System.Drawing.Point(38, 89);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(95, 29);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "<none>";
            // 
            // gbChat
            // 
            this.gbChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbChat.Controls.Add(this.rtbChat);
            this.gbChat.Location = new System.Drawing.Point(50, 58);
            this.gbChat.Name = "gbChat";
            this.gbChat.Size = new System.Drawing.Size(792, 880);
            this.gbChat.TabIndex = 8;
            this.gbChat.TabStop = false;
            this.gbChat.Text = "Общий чат";
            // 
            // gbInfo
            // 
            this.gbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInfo.Controls.Add(this.lblUserSign);
            this.gbInfo.Controls.Add(this.lblUser);
            this.gbInfo.Controls.Add(this.lblServerStatus);
            this.gbInfo.Controls.Add(this.lblServerStatusSign);
            this.gbInfo.Location = new System.Drawing.Point(877, 416);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(863, 215);
            this.gbInfo.TabIndex = 9;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Информация";
            // 
            // gbSendMessage
            // 
            this.gbSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSendMessage.Controls.Add(this.rtbMessage);
            this.gbSendMessage.Controls.Add(this.btnSendMessage);
            this.gbSendMessage.Enabled = false;
            this.gbSendMessage.Location = new System.Drawing.Point(877, 58);
            this.gbSendMessage.Name = "gbSendMessage";
            this.gbSendMessage.Size = new System.Drawing.Size(863, 314);
            this.gbSendMessage.TabIndex = 10;
            this.gbSendMessage.TabStop = false;
            this.gbSendMessage.Text = "Отправка сообщения";
            // 
            // gbLogin
            // 
            this.gbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.lblPassword);
            this.gbLogin.Controls.Add(this.lblEmail);
            this.gbLogin.Controls.Add(this.tbPassword);
            this.gbLogin.Controls.Add(this.tbEmail);
            this.gbLogin.Location = new System.Drawing.Point(877, 668);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(863, 270);
            this.gbLogin.TabIndex = 11;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Авторизация";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(175, 185);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(523, 50);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Вход";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(170, 123);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(178, 25);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Введите пароль:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(170, 53);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(204, 25);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Введите ваш email:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(413, 120);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(285, 31);
            this.tbPassword.TabIndex = 1;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(413, 50);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(285, 31);
            this.tbEmail.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1779, 974);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.gbSendMessage);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbChat);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommonChat";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.gbChat.ResumeLayout(false);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbSendMessage.ResumeLayout(false);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem консольДляSQLКомандToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Label lblServerStatusSign;
        private System.Windows.Forms.Label lblUserSign;
        private System.Windows.Forms.Label lblServerStatus;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolStripMenuItem действиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbChat;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.GroupBox gbSendMessage;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnLogin;
    }
}

