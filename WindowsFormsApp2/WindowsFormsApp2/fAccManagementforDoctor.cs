using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
    public partial class Account : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "kyOX4xGT5lOI4AZXgxF1XfOXFEGMGTjDLTF10DGq",
            BasePath = "https://test2-70b80-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public Account()
        {
            InitializeComponent();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void changepassword_Click(object sender, EventArgs e)
        {
            fChangePassword f = new fChangePassword();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private async void Tai_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse curRes = await client.GetTaskAsync("CurrentAccount");
            Taikhoan acc = curRes.ResultAs<Taikhoan>();

            FirebaseResponse docRes = await client.GetTaskAsync("Account/" + acc.type + "/" + acc.userName);
            Taikhoan admin = docRes.ResultAs<Taikhoan>();

            textName.Text = admin.displayName;
            textAcc.Text = admin.userName;
            textType.Text = admin.type;
        }
    }
}
