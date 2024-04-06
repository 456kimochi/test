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
    public partial class fDangKi : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "kyOX4xGT5lOI4AZXgxF1XfOXFEGMGTjDLTF10DGq",
            BasePath = "https://test2-70b80-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public fDangKi()
        {
            InitializeComponent();
        }

        private void fDangKi_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private async void btnDoctorRegister_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = await client.GetTaskAsync("Counter/Total");

            Counter cnt = res.ResultAs<Counter>();
            if (txtDocAcc.Text.Length != 10 || txtDocAcc.Text[0] != '0')
            {
                MessageBox.Show("Sai định dạng số điện thoại");
                return;
            }

            for (int i = 0; i < cnt.cnt; i++)
            {
                FirebaseResponse listRes = await client.GetTaskAsync("AccountList/" + i);
                AccountList list = listRes.ResultAs<AccountList>();
                if (list.userName == txtDocAcc.Text)
                {
                    MessageBox.Show("Tài khoản đã tồn tại");
                    return;
                }
            }

            FirebaseResponse response = await client.GetTaskAsync("Counter/Doctor");
            Counter docCnt = response.ResultAs<Counter>();

            var data = new Doctor
            {
                userName = txtDocAcc.Text,
                password = txtDocAcc.Text,
                displayName = txtDocName.Text,
                type = "Doctor",
                position = txtPos.Text,
                specialization = txtSpe.Text,
            };

            var count = new Counter
            {
                cnt = cnt.cnt + 1,
            };

            var lst = new AccountList
            {
                type = "Doctor",
                userName = txtDocAcc.Text,
            };

            var doc = new Counter
            {
                cnt = docCnt.cnt + 1,
            };


            SetResponse docSet = await client.SetTaskAsync("Account/Doctor/" + txtDocAcc.Text, data);
            SetResponse cntSet = await client.SetTaskAsync("Counter/Total", count);
            SetResponse lstSet = await client.SetTaskAsync("AccountList/" + cnt.cnt, lst);
            SetResponse docCntSet = await client.SetTaskAsync("Counter/Doctor", doc);

            MessageBox.Show("Đăng kí thành công");
        }

        private async void btnPatRes_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = await client.GetTaskAsync("Counter/Total");

            Counter cnt = res.ResultAs<Counter>();
            if (txtPatAcc.Text.Length != 10 || txtPatAcc.Text[0] != '0')
            {
                MessageBox.Show("Sai định dạng số điện thoại");
                return;
            }


            for (int i = 0; i < cnt.cnt; i++)
            {
                FirebaseResponse listRes = await client.GetTaskAsync("AccountList/" + i);
                AccountList list = listRes.ResultAs<AccountList>();
                if (list.userName == txtPatAcc.Text)
                {
                    MessageBox.Show("Tài khoản đã tồn tại");
                    return;
                }
            }

            FirebaseResponse response = await client.GetTaskAsync("Counter/Patient");
            Counter patCnt = response.ResultAs<Counter>();

            var data = new Patient
            {
                userName = txtPatAcc.Text,
                password = txtPatAcc.Text,
                displayName = txtPatName.Text,
                type = "Patient",
                medicalHistory = txtMedHis.Text,
                testingResult = txtTesRes.Text,
                diagnosis = txtDia.Text,
            };

            var count = new Counter
            {
                cnt = cnt.cnt + 1,
            };

            var lst = new AccountList
            {
                type = "Patient",
                userName = txtPatAcc.Text,
            };

            var pat = new Counter
            {
                cnt = patCnt.cnt + 1,
            };


            SetResponse patSet = await client.SetTaskAsync("Account/Patient/" + txtPatAcc.Text, data);
            SetResponse cntSet = await client.SetTaskAsync("Counter/Total", count);
            SetResponse lstSet = await client.SetTaskAsync("AccountList/" + cnt.cnt, lst);
            SetResponse patCntSet = await client.SetTaskAsync("Counter/Patient", pat);

            MessageBox.Show("Đăng kí thành công");
        }
    }
}
