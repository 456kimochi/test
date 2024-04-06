namespace WindowsFormsApp2
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
            this.panelAcc = new System.Windows.Forms.Panel();
            this.textAcc = new System.Windows.Forms.TextBox();
            this.lblAcc = new System.Windows.Forms.Label();
            this.panelPass = new System.Windows.Forms.Panel();
            this.textPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnForgotpass = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelAcc.SuspendLayout();
            this.panelPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAcc
            // 
            this.panelAcc.Controls.Add(this.textAcc);
            this.panelAcc.Controls.Add(this.lblAcc);
            this.panelAcc.Location = new System.Drawing.Point(251, 57);
            this.panelAcc.Name = "panelAcc";
            this.panelAcc.Size = new System.Drawing.Size(525, 79);
            this.panelAcc.TabIndex = 10;
            // 
            // textAcc
            // 
            this.textAcc.Location = new System.Drawing.Point(215, 33);
            this.textAcc.Name = "textAcc";
            this.textAcc.Size = new System.Drawing.Size(281, 22);
            this.textAcc.TabIndex = 1;
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcc.Location = new System.Drawing.Point(21, 29);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(120, 25);
            this.lblAcc.TabIndex = 0;
            this.lblAcc.Text = "Tài khoản:";
            // 
            // panelPass
            // 
            this.panelPass.Controls.Add(this.textPass);
            this.panelPass.Controls.Add(this.lblPass);
            this.panelPass.Location = new System.Drawing.Point(251, 191);
            this.panelPass.Name = "panelPass";
            this.panelPass.Size = new System.Drawing.Size(525, 79);
            this.panelPass.TabIndex = 11;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(215, 32);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(281, 22);
            this.textPass.TabIndex = 2;
            this.textPass.UseSystemPasswordChar = true;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(21, 29);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(119, 25);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Mật khẩu:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(595, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 51);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(345, 354);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(97, 51);
            this.btnSignIn.TabIndex = 13;
            this.btnSignIn.Text = "Đăng nhập";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.dangnhap_Click);
            // 
            // btnForgotpass
            // 
            this.btnForgotpass.Location = new System.Drawing.Point(110, 354);
            this.btnForgotpass.Name = "btnForgotpass";
            this.btnForgotpass.Size = new System.Drawing.Size(97, 51);
            this.btnForgotpass.TabIndex = 12;
            this.btnForgotpass.Text = "Quên mật khẩu";
            this.btnForgotpass.UseVisualStyleBackColor = true;
            this.btnForgotpass.Click += new System.EventHandler(this.quenmatkhau_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(25, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAcc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelPass);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnForgotpass);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelAcc.ResumeLayout(false);
            this.panelAcc.PerformLayout();
            this.panelPass.ResumeLayout(false);
            this.panelPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAcc;
        private System.Windows.Forms.TextBox textAcc;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelPass;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnForgotpass;
    }
}

