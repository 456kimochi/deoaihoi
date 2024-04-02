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
using FireSharp;


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
            DataTable dt = new DataTable();

            dt.Columns.Add("displayName", typeof(string));
            dt.Columns.Add("userName", typeof(string));
            dt.Columns.Add("password", typeof(string));

            FirebaseResponse cntGet = await client.GetTaskAsync("Counter/node");
            Counter_account cnt = cntGet.ResultAs<Counter_account>();

            for (int i = 0; i<cnt.cnt; i++)
            {
                FirebaseResponse userNameGet = await client.GetTaskAsync("UserName/" +i);
                Key key = userNameGet.ResultAs<Key>();

                FirebaseResponse userGet = await client.GetTaskAsync("Account/" + key.userName);
                Data data = userGet.ResultAs<Data>();

                DataRow row = dt.NewRow();
                row["displayName"] += data.displayName;
                row["userName"] += data.userName;
                row["password"] += data.password;
                dt.Rows.Add(row);
            }
            dgvAccount.DataSource = dt;
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }
    }
}
