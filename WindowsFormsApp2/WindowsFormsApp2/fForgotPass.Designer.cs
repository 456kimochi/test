namespace WindowsFormsApp2
{
    partial class fForgotPass
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btngetPass = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelAcc.SuspendLayout();
            this.panelEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAcc
            // 
            this.panelAcc.Controls.Add(this.textAcc);
            this.panelAcc.Controls.Add(this.label1);
            this.panelAcc.Location = new System.Drawing.Point(39, 25);
            this.panelAcc.Name = "panelAcc";
            this.panelAcc.Size = new System.Drawing.Size(722, 123);
            this.panelAcc.TabIndex = 11;
            this.panelAcc.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textAcc
            // 
            this.textAcc.Location = new System.Drawing.Point(214, 49);
            this.textAcc.Name = "textAcc";
            this.textAcc.Size = new System.Drawing.Size(465, 22);
            this.textAcc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // panelEmail
            // 
            this.panelEmail.Controls.Add(this.textEmail);
            this.panelEmail.Controls.Add(this.label2);
            this.panelEmail.Location = new System.Drawing.Point(39, 164);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(722, 123);
            this.panelEmail.TabIndex = 12;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(214, 49);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(465, 22);
            this.textEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email:";
            // 
            // btngetPass
            // 
            this.btngetPass.Location = new System.Drawing.Point(108, 347);
            this.btngetPass.Name = "btngetPass";
            this.btngetPass.Size = new System.Drawing.Size(141, 66);
            this.btngetPass.TabIndex = 13;
            this.btngetPass.Text = "Lấy lại mật khẩu";
            this.btngetPass.UseVisualStyleBackColor = true;
            this.btngetPass.Click += new System.EventHandler(this.quenmatkhau_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(518, 347);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 66);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.thoat_Click);
            // 
            // fForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btngetPass);
            this.Controls.Add(this.panelEmail);
            this.Controls.Add(this.panelAcc);
            this.Name = "fForgotPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên mật khẩu";
            this.Load += new System.EventHandler(this.quenmatkhau_Load);
            this.panelAcc.ResumeLayout(false);
            this.panelAcc.PerformLayout();
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAcc;
        private System.Windows.Forms.TextBox textAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngetPass;
        private System.Windows.Forms.Button btnExit;
    }
}