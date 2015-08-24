namespace CommonChat
{
    partial class FormRegistration
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
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.gbRegistration = new System.Windows.Forms.GroupBox();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.gbRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(247, 60);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(182, 31);
            this.tbEmail.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(32, 63);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(84, 25);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(32, 128);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(98, 25);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Пароль :";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(247, 125);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(182, 31);
            this.tbPassword.TabIndex = 2;
            // 
            // gbRegistration
            // 
            this.gbRegistration.Controls.Add(this.btnRegistration);
            this.gbRegistration.Controls.Add(this.label2);
            this.gbRegistration.Controls.Add(this.tbLastName);
            this.gbRegistration.Controls.Add(this.lblFirstName);
            this.gbRegistration.Controls.Add(this.tbFirstName);
            this.gbRegistration.Controls.Add(this.lblPassword);
            this.gbRegistration.Controls.Add(this.tbEmail);
            this.gbRegistration.Controls.Add(this.tbPassword);
            this.gbRegistration.Controls.Add(this.lblEmail);
            this.gbRegistration.Location = new System.Drawing.Point(32, 29);
            this.gbRegistration.Name = "gbRegistration";
            this.gbRegistration.Size = new System.Drawing.Size(486, 488);
            this.gbRegistration.TabIndex = 4;
            this.gbRegistration.TabStop = false;
            this.gbRegistration.Text = "Регистрация нового участника чата";
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(37, 362);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(392, 49);
            this.btnRegistration.TabIndex = 8;
            this.btnRegistration.Text = "Зарегистрироваться!";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ваша фамилия :";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(247, 269);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(182, 31);
            this.tbLastName.TabIndex = 6;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(32, 199);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(123, 25);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "Ваше имя :";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(247, 196);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(182, 31);
            this.tbFirstName.TabIndex = 4;
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(540, 545);
            this.Controls.Add(this.gbRegistration);
            this.Name = "FormRegistration";
            this.Text = "FormRegistration";
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            this.gbRegistration.ResumeLayout(false);
            this.gbRegistration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.GroupBox gbRegistration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Button btnRegistration;
    }
}