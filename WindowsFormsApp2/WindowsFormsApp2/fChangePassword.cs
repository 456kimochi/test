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
    public partial class fChangePassword : Form
    {
        public fChangePassword()
        {
            InitializeComponent();
        }

        private void changepass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đổi mật khẩu thành công");
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
