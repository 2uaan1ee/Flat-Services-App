using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;


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
            if(!IsEmail(tbEmail.Text.Trim()))
            {
                MessageBox.Show("Email isn't valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!IsPass(tbPass.Text))
            {
                MessageBox.Show("Length of password must be longger than 8 chars!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(tbconfirmPass.Text != tbPass.Text)
            {
                MessageBox.Show("Password confirmed must be equal password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!IsNumberPhone(tbPhone.Text.Trim()))
            {
                MessageBox.Show("Number phone is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(tbID.Text.Length != 12)
            {
                MessageBox.Show("ID code is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!IsDate(tbDate.Text.Trim()))
            {
                MessageBox.Show("Date of birth is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!cbTerm.Checked)
            {
                MessageBox.Show("Please accept our term!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Sign-up successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Them du lieu vao database
            
            //dieu kien de quay lai login
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        public bool IsEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public bool IsPass(string pass)
        {
            if (pass.Length < 8)
                return false;
            return true;
        }

        public bool IsNumberPhone(string a)
        {
            for(int i=0; i < a.Length;i++)
            {
                if (a[i] == ' ')
                    return false;
            }
            if (a.Length < 10 || a.Length >11)
                return false;
            return true;
        }

        public bool IsDate(string a)
        {
            int dem = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '/')
                    dem++;
            }
            if(dem != 2)
                return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ' ')
                    return false;
            }
            if (a.Length != 10)
                return false;
            string[] s = a.Split('/'); 
            for(int i = 0;i<s.Length;i++)
            {
                if (!int.TryParse(s[i], out dem))
                {
                    return false;
                }
            }
            int day = int.Parse(s[1]);
            int month = int.Parse(s[0]);
            int year = int.Parse(s[2]);
            if(!laNgayHopLe(day, month, year))
                return false; 
            return true;
        }

        // Main.cpp


    // Hàm kiểm tra năm nhuận
    bool laNamNhuan(int nYear)
    {
        if ((nYear % 4 == 0 && nYear % 100 != 0) || nYear % 400 == 0)
        {
            return true;
        }
        return false;

        // <=> return ((nYear % 4 == 0 && nYear % 100 != 0) || nYear % 400 == 0);
    }

    // Hàm trả về số ngày trong tháng thuộc năm cho trước
    int tinhSoNgayTrongThang(int nMonth, int nYear)
    {
        int nNumOfDays =0;

        switch (nMonth)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                nNumOfDays = 31;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                nNumOfDays = 30;
                break;
            case 2:
                if (laNamNhuan(nYear))
                {
                    nNumOfDays = 29;
                }
                else
                {
                    nNumOfDays = 28;
                }
                break;
        }

        return nNumOfDays;
    }

    // Hàm kiểm tra ngày dd/mm/yyyy cho trước có phải là ngày hợp lệ
    bool laNgayHopLe(int nDay, int nMonth, int nYear)
    {
        // Kiểm tra năm
        if (nYear < 0)
        {
            return false; // Ngày không còn hợp lệ nữa!
        }

        // Kiểm tra tháng
        if (nMonth < 1 || nMonth > 12)
        {
            return false; // Ngày không còn hợp lệ nữa!
        }

        // Kiểm tra ngày
        if (nDay < 1 || nDay > tinhSoNgayTrongThang(nMonth, nYear))
        {
            return false; // Ngày không còn hợp lệ nữa!
        }

        return true; // Trả về trạng thái cuối cùng...
    }

        private void Eye1_Click(object sender, EventArgs e)
        {
            Hidden1.BringToFront();
            tbPass.PasswordChar = '\0';
        }

        private void Hidden1_Click(object sender, EventArgs e)
        {
            Eye1.BringToFront();
            tbPass.PasswordChar = '*';
        }

        private void Eye2_Click(object sender, EventArgs e)
        {
            Hidden2.BringToFront();
            tbconfirmPass.PasswordChar = '\0';
        }

        private void Hidden2_Click(object sender, EventArgs e)
        {
            Eye2.BringToFront();
            tbconfirmPass.PasswordChar = '*';
        }
    }
}
