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
    public partial class TernantServices : Form
    {
        public TernantServices()
        {
            InitializeComponent();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeNavigation homeNavigation = new HomeNavigation();
            homeNavigation.Show();
        }

        private void costsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TernantCosts ternantCosts = new TernantCosts();
            ternantCosts.Show();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TernantInformation ternantInformation = new TernantInformation();
            ternantInformation.Show();
        }

        private void chatBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TernantChat ternantChat = new TernantChat();
            ternantChat.Show();
        }
    }
}
