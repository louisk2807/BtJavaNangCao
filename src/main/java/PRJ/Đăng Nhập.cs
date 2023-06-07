using System;
using System.Windows.Forms;

namespace PRJ
{
    public partial class Đăng_Nhập : Form
    {
        public Đăng_Nhập()
        {
            InitializeComponent();
        }

        private string tentaikhoan = "admin";
        private string matkhau = "admin";

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        

       
    }
}