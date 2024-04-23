using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Flat_Services_Application
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void llbSign_up_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Sign_up s = new Sign_up();
            s.Show();
                
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgorPass forgorPass = new ForgorPass();
            forgorPass.Show();  
        }
        int flag = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(rdbtnLessor.Checked)
            {
                flag = 1;
                MessageBox.Show("Enter Lessor form");
                Thread th = new Thread(hienthi);
                th.IsBackground = true;
                th.Start();
            }
            if (rdbynTenant.Checked)
            {
                flag = 1;
                MessageBox.Show("Enter Tenant form");
                Thread th = new Thread(hienthi);
                th.IsBackground = true;
                th.Start();
            }
            if(flag ==0)
            {
                MessageBox.Show("Please choose Tenant or Lessor!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
        }
        public void hienthi()
        {
            Login login = new Login();  
            login.Show();
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

        
        private void cbRemember_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
