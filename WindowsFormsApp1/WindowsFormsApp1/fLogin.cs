using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace WindowsFormsApp1
{
    public partial class fLogin : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "kyOX4xGT5lOI4AZXgxF1XfOXFEGMGTjDLTF10DGq",
            BasePath = "https://test2-70b80-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public fLogin()
        {
            InitializeComponent();
        }
        private void fLogin_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                MessageBox.Show("Kết nối Firebase thành công !!!");
            }
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetTaskAsync("Account/" + insUserName.Text);

            Data obj = response.ResultAs<Data>();

            if (insUserName.Text == obj.userName && insPassword.Text == obj.password)
            {
                fTableManager f = new fTableManager();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Wrong account inserted");
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to quit?", 
                "Message", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = false;
            }
        }

        private async void btnSendata_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                userName = insUserName.Text,
                password = insPassword.Text,
            };

            SetResponse response = await client.SetTaskAsync("Account/"+insUserName.Text, data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show("Data Inserted" + result.userName);

            

        }

        private async void btnReceive_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetTaskAsync("Account/"+insUserName.Text);

            Data obj = response.ResultAs<Data>();

            insUserName.Text = obj.userName;
            insPassword.Text = obj.password;
        }
    }
}
