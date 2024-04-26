using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Net;
using System.Xml.Linq;

namespace Flat_Services_Application
{
    public partial class Login_L : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "48Zjlmy2fXRwFKfmQjmaT91BX8zCcTqzi7o5TsoN",
            BasePath = "https://accountl-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public Login_L()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            _login l = new _login();
            l.Show();
        }

        private void llbSign_up_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            _sign_up s = new _sign_up();
            s.Show();
        }
        public bool IsNumberPhone(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ' ' || (a[i] < '0' && a[i] > '9'))
                    return false;
            }
            if (a.Length < 10 || a.Length > 11)
                return false;
            return true;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbPhoneNumber.Text == "")
            {
                MessageBox.Show("Phone number is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbPass.Text == "")
            {
                lbps2.Text = "*";
                lbps2.ForeColor = Color.Red;
                return;
            }
            if (!IsNumberPhone(tbPhoneNumber.Text))
            {
                MessageBox.Show("Phone number is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            FirebaseResponse Response = await client.GetAsync("Account Lessor/" + tbPhoneNumber.Text);
            if (Response.Body == "null")
            {
                lbps1.Text = "Account is not existed";
                lbps1.ForeColor = Color.Red;
                return;
            }
            else
            {
                lbps1.Text = "";

            }
            Data obj = Response.ResultAs<Data>();

            if (cbRemember.Checked)
            {
                tbPass.Text = obj.pass;
                tbPass.PasswordChar = '*';
            }
            else
            {
                tbPass.PasswordChar = '\0';
            }

            if (tbPass.Text != obj.pass)
            {
                lbps2.Text = "Wrong";
                lbps2.ForeColor = Color.Red;
                return;
            }
            else
            {
                lbps2.Text = "";

            }
            MessageBox.Show("Enter lessor!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Login_L_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client == null)
                MessageBox.Show("Connected isn't Successful!");
        }

        private void Eye_Click(object sender, EventArgs e)
        {
            Hidden.BringToFront();
            tbPass.PasswordChar = '\0';
        }

        private void Hidden_Click(object sender, EventArgs e)
        {
            Eye.BringToFront();
            tbPass.PasswordChar = '*';
        }

        private void tc_number(object sender, EventArgs e)
        {
            if (tbPhoneNumber.Text != "")
                lbps1.Text = "";
            else
            {
                lbps1.Text = "*";
                lbps1.ForeColor = Color.Red;
            }
        }

        private void tc_pass(object sender, EventArgs e)
        {

            if (tbPass.Text != "")
                lbps2.Text = "";
            else
            {
                lbps2.Text = "*";
                lbps2.ForeColor = Color.Red;
            }
        }
    }
}
