using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

            LoadAccountList();
        }

        void LoadAccountList()
        {
            string query = "exec dbo.USP_GetAccountByUserName @userName";

            DataProvider provider = new DataProvider();

            dgvAccount.DataSource = provider.ExcuteQuery(query, new object[]{"staff"});
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
