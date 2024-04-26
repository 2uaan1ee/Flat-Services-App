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
    public partial class Payment_Lessor : Form
    {
        public Payment_Lessor()
        {
            InitializeComponent();
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Lessor home_Lessor = new Home_Lessor();
            home_Lessor.Show();
        }

        private void Flat_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flat_Management_Lessor flat_Management_Lessor = new Flat_Management_Lessor();
            flat_Management_Lessor.Show();
        }

        private void Accept_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accept_Tenant_Lessor accept_Tenant_Lessor = new Accept_Tenant_Lessor();
            accept_Tenant_Lessor.Show();
        }

        private void Chat_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chat_Lessor chat_Lessor = new Chat_Lessor();
            chat_Lessor.Show();
        }

        private void Setting_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Setting_Lessor setting_Lessor = new Setting_Lessor();
            setting_Lessor.Show();
        }

        private void Charge_btn_Click(object sender, EventArgs e)
        {
            Charge_Lessor charge_Lessor = new Charge_Lessor();
            charge_Lessor.Show();
        }
    }
}
