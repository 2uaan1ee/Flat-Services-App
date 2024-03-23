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
    public partial class ForgorPass : Form
    {
        public ForgorPass()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Login login = new Login();  
            login.Show();   
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("a new password will be sent to your Email!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
