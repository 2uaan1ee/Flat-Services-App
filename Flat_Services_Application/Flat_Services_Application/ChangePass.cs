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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // dieu kien xet day phai la mat khau hien tai hay k -> kiem tra trong database
            
            if(!IsPass(tbNewPass.Text))
            {
                MessageBox.Show("Password is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(tbConfirmNew.Text != tbNewPass.Text)
            {
                MessageBox.Show("New password and Confirm new password are differnet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Change Password successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //dieu kien de confirm
            this.Hide();
            Login login = new Login();  
            login.Show();
        }

        public bool IsPass(string pass)
        {
            if (pass.Length < 8)
                return false;
            return true;
        }

        private void Hidden1_Click(object sender, EventArgs e)
        {
            tbCurrPass.PasswordChar = '*';
            Eye1.BringToFront();
        }

        private void Hidden2_Click(object sender, EventArgs e)
        {
            tbNewPass.PasswordChar = '*';
            Eye2.BringToFront();
        }

        private void Hidden3_Click(object sender, EventArgs e)
        {
            tbConfirmNew.PasswordChar = '*';
            Eye3.BringToFront();
        }

        private void Eye1_Click(object sender, EventArgs e)
        {
            tbCurrPass.PasswordChar = '\0';
            Eye1.SendToBack();
        }

        private void Eye2_Click(object sender, EventArgs e)
        {
            tbNewPass.PasswordChar = '\0';
            Eye2.SendToBack();
        }

        private void Eye3_Click(object sender, EventArgs e)
        {
            tbConfirmNew.PasswordChar = '\0';
            Eye3.SendToBack();
        }
    }
}
