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
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class fPatient : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "kyOX4xGT5lOI4AZXgxF1XfOXFEGMGTjDLTF10DGq",
            BasePath = "https://test2-70b80-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public fPatient()
        {
            InitializeComponent();
        }

        private async void fPatient_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse curRes = await client.GetTaskAsync("CurrentAccount");
            Taikhoan acc = curRes.ResultAs<Taikhoan>();

            FirebaseResponse patRes = await client.GetTaskAsync("Account/" + acc.type + "/" + acc.userName);
            Taikhoan pat = patRes.ResultAs<Doctor>();

            txtName.Text = pat.displayName;
            txtDia.Text = pat.diagnosis;
            txtMedHis.Text = pat.medicalHistory;
            txtTesRes.Text = pat.testingResult;
        }
    }
}
