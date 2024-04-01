namespace WindowsFormsApp1
{
    partial class fLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.insPassword = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.insUserName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.Label();
            this.btnSendata = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReceive);
            this.panel1.Controls.Add(this.btnSendata);
            this.panel1.Controls.Add(this.btnQuit);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 256);
            this.panel1.TabIndex = 1;
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Location = new System.Drawing.Point(435, 204);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(90, 31);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(319, 204);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(82, 31);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.insPassword);
            this.panel3.Controls.Add(this.txtPassWord);
            this.panel3.Location = new System.Drawing.Point(3, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(556, 78);
            this.panel3.TabIndex = 1;
            // 
            // insPassword
            // 
            this.insPassword.Location = new System.Drawing.Point(206, 32);
            this.insPassword.Name = "insPassword";
            this.insPassword.Size = new System.Drawing.Size(332, 22);
            this.insPassword.TabIndex = 1;
            this.insPassword.UseSystemPasswordChar = true;
            // 
            // txtPassWord
            // 
            this.txtPassWord.AutoSize = true;
            this.txtPassWord.Font = new System.Drawing.Font("UTM Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Location = new System.Drawing.Point(18, 19);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(139, 40);
            this.txtPassWord.TabIndex = 0;
            this.txtPassWord.Text = "PassWord:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.insUserName);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 82);
            this.panel2.TabIndex = 0;
            // 
            // insUserName
            // 
            this.insUserName.Location = new System.Drawing.Point(206, 43);
            this.insUserName.Name = "insUserName";
            this.insUserName.Size = new System.Drawing.Size(332, 22);
            this.insUserName.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.Font = new System.Drawing.Font("UTM Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(18, 30);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(147, 40);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "User Name:";
            // 
            // btnSendata
            // 
            this.btnSendata.Location = new System.Drawing.Point(151, 197);
            this.btnSendata.Name = "btnSendata";
            this.btnSendata.Size = new System.Drawing.Size(90, 45);
            this.btnSendata.TabIndex = 4;
            this.btnSendata.Text = "Send Data";
            this.btnSendata.UseVisualStyleBackColor = true;
            this.btnSendata.Click += new System.EventHandler(this.btnSendata_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(28, 197);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(90, 45);
            this.btnReceive.TabIndex = 5;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // fLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(601, 280);
            this.Controls.Add(this.panel1);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox insPassword;
        private System.Windows.Forms.Label txtPassWord;
        private System.Windows.Forms.TextBox insUserName;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSendata;
        private System.Windows.Forms.Button btnReceive;
    }
}

