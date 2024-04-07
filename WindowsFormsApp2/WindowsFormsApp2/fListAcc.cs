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
    public partial class fListAcc : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "kyOX4xGT5lOI4AZXgxF1XfOXFEGMGTjDLTF10DGq",
            BasePath = "https://test2-70b80-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public fListAcc()
        {
            InitializeComponent();
        }

        private async void fListAcc_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);          
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("displayName", typeof(string));
            dt.Columns.Add("userName", typeof(string));
            dt.Columns.Add("password", typeof(string));
            dt.Columns.Add("type", typeof(string));

            dt.Columns["displayName"].ReadOnly = true;
            dt.Columns["userName"].ReadOnly = true;
            dt.Columns["password"].ReadOnly = true;
            dt.Columns["type"].ReadOnly = true;

            FirebaseResponse cntGet = await client.GetTaskAsync("Counter/Total");
            Counter cnt = cntGet.ResultAs<Counter>();

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < cnt.cnt; i++)
                {
                    FirebaseResponse userNameGet = await client.GetTaskAsync("AccountList/" + i);
                    AccountList list = userNameGet.ResultAs<AccountList>();

                    if (j == 0)
                    {
                        if (list.type == "Admin")
                        {
                            FirebaseResponse userGet = await client.GetTaskAsync("Account/Admin/" + list.userName);
                            Taikhoan data = userGet.ResultAs<Admin>();
                            DataRow row = dt.NewRow();
                            row["displayName"] += data.displayName;
                            row["userName"] += data.userName;
                            row["password"] += data.password;
                            row["type"] += data.type;
                            dt.Rows.Add(row);
                        }
                        else continue;
                    }
                    else if (j == 1)
                    {
                        if (list.type == "Doctor")
                        {
                            FirebaseResponse userGet = await client.GetTaskAsync("Account/Doctor/" + list.userName);
                            Taikhoan data = userGet.ResultAs<Admin>();
                            DataRow row = dt.NewRow();
                            row["displayName"] += data.displayName;
                            row["userName"] += data.userName;
                            row["password"] += data.password;
                            row["type"] += data.type;
                            dt.Rows.Add(row);
                        }
                        else continue;
                    }
                    else if (j == 2)
                    {
                        if (list.type == "Patient")
                        {
                            FirebaseResponse userGet = await client.GetTaskAsync("Account/Patient/" + list.userName);
                            Taikhoan data = userGet.ResultAs<Admin>();
                            DataRow row = dt.NewRow();
                            row["displayName"] += data.displayName;
                            row["userName"] += data.userName;
                            row["password"] += data.password;
                            row["type"] += data.type;
                            dt.Rows.Add(row);
                        }
                        else continue;
                    }
                }
            }
            dgvAccList.DataSource = dt;
        }
    }
}
