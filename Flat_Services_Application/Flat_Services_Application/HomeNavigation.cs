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
    public partial class HomeNavigation : Form
    {
        public HomeNavigation()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
