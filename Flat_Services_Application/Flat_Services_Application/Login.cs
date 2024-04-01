using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(rdbtnLessor.Checked)
            {
                MessageBox.Show("enter Lessor form");
            }
            else
            {
                this.Hide();
                JoinFlat joinFlat = new JoinFlat();
                joinFlat.Show();
            }    
        }
    }
}
