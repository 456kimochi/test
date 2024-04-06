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
    public partial class fForgotPass : Form
    {
        public fForgotPass()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void quenmatkhau_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mật khẩu mới của bạn là abc123");
            this.Close();
        }
        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void quenmatkhau_Load(object sender, EventArgs e)
        {

        }
    }
}
