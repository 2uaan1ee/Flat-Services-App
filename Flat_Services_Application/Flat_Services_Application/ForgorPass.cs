﻿using System;
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
            
            this.Hide();
            ChangePass c = new ChangePass();
            c.Show();
        }
    }
}
