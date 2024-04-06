using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace WindowsFormsApp2
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
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
        private void quenmatkhau_Click(object sender, EventArgs e)
        {
            fForgotPass f = new fForgotPass();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }
        private async void dangnhap_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetTaskAsync("Counter/Total");

            Counter cnt = response.ResultAs<Counter>();


            for (int i=0; i < cnt.cnt; i++)
            {
                FirebaseResponse listRes = await client.GetTaskAsync("AccountList/"+i);
                AccountList list = listRes.ResultAs<AccountList>();
                if (list.userName == textAcc.Text)
                {
                    FirebaseResponse accRes = await client.GetTaskAsync("Account/" + list.type + "/" + list.userName);
                    Taikhoan acc = accRes.ResultAs<Taikhoan>();
                    if (acc.password == textPass.Text)
                    {
                        if (acc.type == "Admin")
                        {
                            fInterface f = new fInterface();
                            this.Hide();
                            f.ShowDialog();
                            this.Show();    
                        }
                        else if (acc.type == "Doctor")
                        {
                            fDoctor f = new fDoctor();
                            this.Hide();
                            f.ShowDialog();
                            this.Show();
                        }
                        else{
                            fPatient f = new fPatient();
                            this.Hide();
                            f.ShowDialog();
                            this.Show();
                        }
                        return;
                    }
                    MessageBox.Show("Sai mật khẩu");
                    return;
                }
            }
            MessageBox.Show("Tài khoản không tồn tại");

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình?","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }
    }
}
