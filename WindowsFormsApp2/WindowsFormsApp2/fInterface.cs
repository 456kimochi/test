using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class fInterface : Form
    {
        public fInterface()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void quanlitaikhoan_Click(object sender, EventArgs e)
        {
            fAccManagementforAdmin f = new fAccManagementforAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }
        private void benhnhan_Click(object sender, EventArgs e)
        {
            fPatientforAdmin f = new fPatientforAdmin();

            this.Hide();
            f.ShowDialog();
            this.Show();


        }
        private void thietbiyte_Click(object sender, EventArgs e)
        {
            fMedicalEqipment f = new fMedicalEqipment();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }
        private void nhanvienyte_Click(object sender, EventArgs e)
        {
            fDoctorforAdmin f = new fDoctorforAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            fDangKi f = new fDangKi();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
