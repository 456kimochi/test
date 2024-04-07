namespace WindowsFormsApp2
{
    partial class fPatient
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtTesRes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtMedHis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel19 = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.panel20 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(877, 462);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(869, 433);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Thông tin cá nhân";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnChangePass);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(866, 419);
            this.panel3.TabIndex = 6;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(48, 343);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(128, 68);
            this.btnChangePass.TabIndex = 6;
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtDate);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(3, 54);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(863, 44);
            this.panel6.TabIndex = 5;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.txtDate.Location = new System.Drawing.Point(179, 3);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(681, 32);
            this.txtDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày vào viện:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtDia);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Location = new System.Drawing.Point(0, 292);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(860, 45);
            this.panel9.TabIndex = 4;
            // 
            // txtDia
            // 
            this.txtDia.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.txtDia.Location = new System.Drawing.Point(179, 3);
            this.txtDia.Multiline = true;
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(678, 27);
            this.txtDia.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chẩn đoán:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtTesRes);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(2, 204);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(861, 82);
            this.panel8.TabIndex = 3;
            // 
            // txtTesRes
            // 
            this.txtTesRes.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.txtTesRes.Location = new System.Drawing.Point(180, 3);
            this.txtTesRes.Multiline = true;
            this.txtTesRes.Name = "txtTesRes";
            this.txtTesRes.Size = new System.Drawing.Size(678, 76);
            this.txtTesRes.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 50);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết quả xét \r\nnghiệm:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtMedHis);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(2, 104);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(861, 94);
            this.panel7.TabIndex = 2;
            // 
            // txtMedHis
            // 
            this.txtMedHis.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.txtMedHis.Location = new System.Drawing.Point(180, 3);
            this.txtMedHis.Multiline = true;
            this.txtMedHis.Name = "txtMedHis";
            this.txtMedHis.Size = new System.Drawing.Size(678, 81);
            this.txtMedHis.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lịch sử bệnh án:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtName);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(862, 44);
            this.panel5.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(178, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(681, 32);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel19);
            this.tabPage3.Controls.Add(this.panel20);
            this.tabPage3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(869, 433);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tiến triển";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.btnView);
            this.panel19.Controls.Add(this.dtpToDate);
            this.panel19.Controls.Add(this.dtpFromDate);
            this.panel19.Location = new System.Drawing.Point(55, 3);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(756, 29);
            this.panel19.TabIndex = 3;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(339, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(92, 27);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(553, 3);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(200, 25);
            this.dtpToDate.TabIndex = 1;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(3, 3);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(200, 25);
            this.dtpFromDate.TabIndex = 0;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.dgv);
            this.panel20.Location = new System.Drawing.Point(55, 38);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(759, 406);
            this.panel20.TabIndex = 2;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 3);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(759, 389);
            this.dgv.TabIndex = 0;
            // 
            // fPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 479);
            this.Controls.Add(this.tabControl1);
            this.Name = "fPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bệnh nhân";
            this.Load += new System.EventHandler(this.fPatient_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtTesRes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtMedHis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangePass;
    }
}