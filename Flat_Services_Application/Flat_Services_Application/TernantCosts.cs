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
    public partial class TernantCosts : Form
    {
        public TernantCosts()
        {
            InitializeComponent();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TernantInformation ternantInformation = new TernantInformation();
            ternantInformation.Show();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeNavigation homeNavigation = new HomeNavigation();
            homeNavigation.Show();
        }

        private void servicesBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TernantServices ternantServices = new TernantServices();
            ternantServices.Show();
        }

        private void chatBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TernantChat ternantChat = new TernantChat();
            ternantChat.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
