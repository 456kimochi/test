namespace WindowsFormsApp2
{
    partial class fAccManagementforAdmin
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
            this.panelName = new System.Windows.Forms.Panel();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelAcc = new System.Windows.Forms.Panel();
            this.textAcc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListAcc = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelAcc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.textName);
            this.panelName.Controls.Add(this.label1);
            this.panelName.Location = new System.Drawing.Point(322, 47);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(457, 60);
            this.panelName.TabIndex = 13;
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(191, 12);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(263, 34);
            this.textName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(26, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panelAcc
            // 
            this.panelAcc.Controls.Add(this.textAcc);
            this.panelAcc.Controls.Add(this.label2);
            this.panelAcc.Location = new System.Drawing.Point(322, 137);
            this.panelAcc.Name = "panelAcc";
            this.panelAcc.Size = new System.Drawing.Size(457, 60);
            this.panelAcc.TabIndex = 14;
            // 
            // textAcc
            // 
            this.textAcc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAcc.Location = new System.Drawing.Point(191, 12);
            this.textAcc.Name = "textAcc";
            this.textAcc.Size = new System.Drawing.Size(263, 34);
            this.textAcc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // btnListAcc
            // 
            this.btnListAcc.Location = new System.Drawing.Point(26, 333);
            this.btnListAcc.Name = "btnListAcc";
            this.btnListAcc.Size = new System.Drawing.Size(199, 80);
            this.btnListAcc.TabIndex = 16;
            this.btnListAcc.Text = "Danh sách tài khoản";
            this.btnListAcc.UseVisualStyleBackColor = true;
            this.btnListAcc.Click += new System.EventHandler(this.danhsachtaikhoanquantri_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(308, 333);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(199, 80);
            this.btnChangePass.TabIndex = 17;
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.changepassword_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(580, 333);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(199, 80);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.exit_Click);
            // 
            // fAccManagementforAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.btnListAcc);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelAcc);
            this.Name = "fAccManagementforAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.fAccManagementforAdmin_Load);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelAcc.ResumeLayout(false);
            this.panelAcc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelAcc;
        private System.Windows.Forms.TextBox textAcc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListAcc;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnExit;
    }
}