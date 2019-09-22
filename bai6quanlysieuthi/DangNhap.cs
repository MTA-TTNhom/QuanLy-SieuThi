using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai6quanlysieuthi
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text;
            string password = txtMatKhau.Text;
            if (true)
            {
                TrangChu f = new TrangChu();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên khoài khoản hoặc mật khẩu!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
                if (e.KeyCode == Keys.Enter)
                    btnDangNhap.Focus();
            }
        }
        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtMatKhau.Focus();
        }
        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap.Focus();
        }
    }
}
