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
using FireSharp;
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
            FirebaseResponse count = await client.GetTaskAsync("Counter/node");
            Counter_account cnt = count.ResultAs<Counter_account>();
            for (int i = 0; i < cnt.cnt; i++)
            {
                FirebaseResponse userGet = await client.GetTaskAsync("UserName/" + i);
                Key key = userGet.ResultAs<Key>();
                if (insUserName.Text == key.userName)
                {
                    FirebaseResponse response = await client.GetTaskAsync("Account/" + insUserName.Text);
                    Data obj = response.ResultAs<Data>();

                    if (insPassword.Text == obj.password)
                    {
                        fTableManager f = new fTableManager();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password inserted");
                    }
                    return;
                }
            }
            MessageBox.Show("Account does not exist");
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

        private void btnRegis_Click(object sender, EventArgs e)
        {
            fRegister f = new fRegister();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
