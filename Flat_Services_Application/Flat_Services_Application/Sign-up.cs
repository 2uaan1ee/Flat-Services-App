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
    public partial class Sign_up : Form
    {
        public Sign_up()
        {
            InitializeComponent();
        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void btnSign_up_Click(object sender, EventArgs e)
        {
            //dieu kien de quay lai login
            this.Hide();
            Login l = new Login();
            l.Show();
        }
    }
}
