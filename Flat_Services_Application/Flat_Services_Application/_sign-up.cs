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
    public partial class _sign_up : Form
    {
        public _sign_up()
        {
            InitializeComponent();
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {

        }

        private void btSignup_Click(object sender, EventArgs e)
        {
            
            if(rdbynTenant.Checked)
            {
                this.Hide();    
                Sign_up s = new Sign_up();
                s.Show();
                
            }
            if(rdbtnLessor.Checked)
            {
                this.Hide();
                sign_up_L s = new sign_up_L();
                s.Show();
            }
        }
    }
}
