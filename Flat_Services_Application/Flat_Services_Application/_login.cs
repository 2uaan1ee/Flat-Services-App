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
    public partial class _login : Form
    {
        public _login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if(rdbynTenant.Checked)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            if(rdbtnLessor.Checked) 
            {
                this.Hide();
                Login_L l = new Login_L();
                l.Show();
            }
        }
    }
}
