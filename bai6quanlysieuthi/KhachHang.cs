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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        private void menuTrangChu_Click(object sender, EventArgs e)
        {
            TrangChu f = new TrangChu();
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
        private void btnSearchKh_Click(object sender, EventArgs e)
        {
            if (cmbSearchKh.Text == @"Mã khách hàng")
            {
                if (txtSearchKh.Text != "")
                {
                    dgvKh.DataSource = KhachhangController.Instance.SearchKh(txtSearchKh.Text);
                }
            }
            else if (cmbSearchKh.Text == @"Số điện thoại")
            {
                if (txtSearchKh.Text != "")
                {
                    dgvKh.DataSource = KhachhangController.Instance.SearchKh1(txtSearchKh.Text);
                }
            }
        }
    }
}
