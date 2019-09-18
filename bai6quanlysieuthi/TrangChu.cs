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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            KhachHang f = new KhachHang();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            HangHoa f = new HangHoa();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien f = new NhanVien();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            HuongDan f = new HuongDan();
            f.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            login f = new login();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
#endregion

        #region menustrip

        private void menuKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang f = new KhachHang();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void menuHangHoa_Click(object sender, EventArgs e)
        {
            HangHoa f = new HangHoa();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void menuNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien f = new NhanVien();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void menuHuongDan_Click(object sender, EventArgs e)
        {
            HuongDan f = new HuongDan();
            f.ShowDialog();
        }
        #endregion

        private void btnHuongDan_Click_1(object sender, EventArgs e)
        {

        }

        private void btnkhachhang_Click_1(object sender, EventArgs e)
        {

        }

        private void btnHangHoa_Click_1(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click_1(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {

        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            TrangChu a = new TrangChu();
            Hide();
            a.Show();
        }
    }
}
