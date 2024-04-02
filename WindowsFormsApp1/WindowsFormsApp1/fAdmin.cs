using FireSharp.Response;
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
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class fAdmin : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "kyOX4xGT5lOI4AZXgxF1XfOXFEGMGTjDLTF10DGq",
            BasePath = "https://test2-70b80-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public fAdmin()
        {
            InitializeComponent();
        }

        void LoadAccountList()
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            /*DataTable dt = new DataTable();

            dt.Columns.Add("userName", typeof(string));
            dt.Columns.Add("password", typeof(string));

            FirebaseResponse response = await client.GetTaskAsync("Account/456kimochi");

            Data obj = response.ResultAs<Data>();

            DataRow row = dt.NewRow();
            row["userName"] = obj.userName;
            row["password"] = obj.password;
            dt.Rows.Add(row);

            FirebaseResponse response2 = await client.GetTaskAsync("Account/huyducbhn");

            Data obj2 = response2.ResultAs<Data>();

            DataRow row2 = dt.NewRow();
            row2["userName"] = obj2.userName;
            row2["password"] = obj2.password;
            dt.Rows.Add(row2);
            dgvAccount.DataSource = dt;*/
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }
    }
}
