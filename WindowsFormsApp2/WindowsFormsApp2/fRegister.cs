<<<<<<< HEAD:WindowsFormsApp2/WindowsFormsApp2/fRegister.cs
﻿using System;
=======
﻿using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
>>>>>>> ef857d9486eb9604dc970025cf4a11149d66f700:WindowsFormsApp1/WindowsFormsApp1/fRegister.cs
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<< HEAD:WindowsFormsApp2/WindowsFormsApp2/fRegister.cs
namespace WindowsFormsApp2
{
    public partial class fRegister : Form
    {
=======
namespace WindowsFormsApp1
{
    public partial class fRegister : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "kyOX4xGT5lOI4AZXgxF1XfOXFEGMGTjDLTF10DGq",
            BasePath = "https://test2-70b80-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
>>>>>>> ef857d9486eb9604dc970025cf4a11149d66f700:WindowsFormsApp1/WindowsFormsApp1/fRegister.cs
        public fRegister()
        {
            InitializeComponent();
        }
<<<<<<< HEAD:WindowsFormsApp2/WindowsFormsApp2/fRegister.cs
=======

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (insDisplayName.Text != "" &&  insPassword.Text != "" && insUserName.Text != "")
            {
                FirebaseResponse cntGet = await client.GetTaskAsync("Counter/node");
                Counter_account cnt = cntGet.ResultAs<Counter_account>();

                for (int i = 0; i < cnt.cnt; i++)
                {
                    FirebaseResponse userGet = await client.GetTaskAsync("UserName/" + i);
                    Key userName = userGet.ResultAs<Key>();
                    if (insUserName.Text == userName.userName)
                    {
                        MessageBox.Show("Account existed");
                        return;
                    }
                }

                if (insRe_enter.Text != insPassword.Text)
                {
                    MessageBox.Show("Password does not match");
                    return;
                }
                
                var cntVar = new Counter_account
                {
                    cnt = cnt.cnt + 1,
                };
                FirebaseResponse cntSet = await client.UpdateTaskAsync("Counter/node", cntVar);


                var data = new Data
                {
                    displayName = insDisplayName.Text,
                    userName = insUserName.Text,
                    password = insPassword.Text,
                };
                SetResponse response = await client.SetTaskAsync("Account/" + data.userName, data);


                var key = new Key
                {
                    userName = insUserName.Text,
                };
                SetResponse keySet = await client.SetTaskAsync("UserName/" + cnt.cnt, key);


                Data result = response.ResultAs<Data>();
                MessageBox.Show("Data Inserted " + result.userName);
            }
            
        }

        private void fRegister_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }
>>>>>>> ef857d9486eb9604dc970025cf4a11149d66f700:WindowsFormsApp1/WindowsFormsApp1/fRegister.cs
    }
}
