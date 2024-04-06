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
    public partial class fChangePassword : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "kyOX4xGT5lOI4AZXgxF1XfOXFEGMGTjDLTF10DGq",
            BasePath = "https://test2-70b80-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public fChangePassword()
        {
            InitializeComponent();
        }

        private async void changepass_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text != txtReNewPass.Text)
            {
                MessageBox.Show("Mật khẩu không khớp");
                return;
            }
            FirebaseResponse curRes = await client.GetTaskAsync("CurrentAccount");
            Taikhoan acc = curRes.ResultAs<Taikhoan>();

            FirebaseResponse response = await client.GetTaskAsync("Account/" + acc.type + "/" + acc.userName);
            acc = response.ResultAs<Taikhoan>();
            if (txtOldPass.Text != acc.password)
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
                return;
            }
            if (acc.type == "Admin")
            {
                acc = response.ResultAs<Admin>();
                var data = new Doctor
                {
                    userName = acc.userName,
                    password = txtNewPass.Text,
                    displayName = acc.displayName,
                    type = acc.type,
                };
                FirebaseResponse res = await client.UpdateTaskAsync("Account/" + acc.type + "/" + acc.userName, data);
            }
            else if (acc.type == "Doctor")
            {
                acc = response.ResultAs<Doctor>();
                var data = new Doctor
                {
                    userName = acc.userName,
                    password = txtNewPass.Text,
                    displayName = acc.displayName,
                    type = acc.type,
                    position = acc.position,
                    specialization = acc.specialization,
                };
                FirebaseResponse res = await client.UpdateTaskAsync("Account/" + acc.type + "/" + acc.userName, data);
            }
            else
            {
                acc = response.ResultAs<Patient>();
                var data = new Patient
                {
                    userName = acc.userName,
                    password = txtNewPass.Text,
                    displayName = acc.displayName,
                    type = acc.type,
                    medicalHistory = acc.medicalHistory,
                    testingResult = acc.testingResult,
                    diagnosis = acc.diagnosis,
                };
                FirebaseResponse res = await client.UpdateTaskAsync("Account/" + acc.type + "/" + acc.userName, data);
            }

            MessageBox.Show("Đổi mật khẩu thành công");
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fChangePassword_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }
    }
}
