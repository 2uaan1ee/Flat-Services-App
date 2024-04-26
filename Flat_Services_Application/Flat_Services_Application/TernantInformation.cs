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
    public partial class TernantInformation : Form
    {
        public TernantInformation()
        {
            InitializeComponent();
        }

        private void TernantInformation_Load(object sender, EventArgs e)
        {

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

        private void servicesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TernantServices ternantServices = new TernantServices();
            ternantServices.Show();
        }

        private void chatBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TernantChat ternantChat = new TernantChat();
            ternantChat.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            this.infoBtn.BackColor = Color.DarkGreen;
            this.infoBtn.ForeColor = Color.White;
        }
    }
}
