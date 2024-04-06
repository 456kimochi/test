namespace WindowsFormsApp2
{
    partial class Account
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
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.panelName = new System.Windows.Forms.Panel();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textPosition = new System.Windows.Forms.TextBox();
            this.panelPosition = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textAcc = new System.Windows.Forms.TextBox();
            this.panelAcc = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelName.SuspendLayout();
            this.panelPosition.SuspendLayout();
            this.panelAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên:";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.textName.Location = new System.Drawing.Point(191, 12);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(263, 32);
            this.textName.TabIndex = 1;
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.textName);
            this.panelName.Controls.Add(this.label1);
            this.panelName.Location = new System.Drawing.Point(320, 42);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(457, 60);
            this.panelName.TabIndex = 20;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btnChangePass.Location = new System.Drawing.Point(95, 329);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(199, 80);
            this.btnChangePass.TabIndex = 24;
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.changepassword_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(511, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(199, 80);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chức vụ:";
            // 
            // textPosition
            // 
            this.textPosition.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.textPosition.Location = new System.Drawing.Point(191, 12);
            this.textPosition.Name = "textPosition";
            this.textPosition.Size = new System.Drawing.Size(263, 32);
            this.textPosition.TabIndex = 1;
            // 
            // panelPosition
            // 
            this.panelPosition.Controls.Add(this.textPosition);
            this.panelPosition.Controls.Add(this.label3);
            this.panelPosition.Location = new System.Drawing.Point(320, 214);
            this.panelPosition.Name = "panelPosition";
            this.panelPosition.Size = new System.Drawing.Size(457, 60);
            this.panelPosition.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tài khoản:";
            // 
            // textAcc
            // 
            this.textAcc.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.textAcc.Location = new System.Drawing.Point(191, 12);
            this.textAcc.Name = "textAcc";
            this.textAcc.Size = new System.Drawing.Size(263, 32);
            this.textAcc.TabIndex = 1;
            // 
            // panelAcc
            // 
            this.panelAcc.Controls.Add(this.textAcc);
            this.panelAcc.Controls.Add(this.label2);
            this.panelAcc.Location = new System.Drawing.Point(320, 132);
            this.panelAcc.Name = "panelAcc";
            this.panelAcc.Size = new System.Drawing.Size(457, 60);
            this.panelAcc.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(24, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelAcc);
            this.Controls.Add(this.panelPosition);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChangePass);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Account";
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.Tai_Load);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelPosition.ResumeLayout(false);
            this.panelPosition.PerformLayout();
            this.panelAcc.ResumeLayout(false);
            this.panelAcc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPosition;
        private System.Windows.Forms.Panel panelPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAcc;
        private System.Windows.Forms.Panel panelAcc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}