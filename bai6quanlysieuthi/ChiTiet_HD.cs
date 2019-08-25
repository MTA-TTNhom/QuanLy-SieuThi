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
    public partial class ChiTiet_HD : Form
    {
        public ChiTiet_HD()
        {
            InitializeComponent();
        }

        private void btnInsert_CTHD_Click(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text == "" || cbMaMatHang.Text == "" || txtSoLuong.Text == "")
            {
                if (txtMaHoaDon.Text == "")
                    errorProvider1.SetError(txtMaHoaDon, "Chưa có dữ liệu");
                if (cbMaMatHang.Text == "")
                    errorProvider1.SetError(cbMaMatHang, "Chưa có dữ liệu");
                if (txtSoLuong.Text == "")
                    errorProvider1.SetError(txtSoLuong, "Chưa có dữ liệu");
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string mahd = txtMaHoaDon.Text;
                string mamh = cbMaMatHang.Text;
                int sl = (int)Convert.ToInt32(txtSoLuong.Text);
                if (txtMaHoaDon.Text == "" || cbMaMatHang.Text == "" || txtSoLuong.Text == "")
                {
                    MessageBox.Show("Phải điền thông tin đầy đủ");
                    return;
                }
                if (CtHoaDonController.Instance.InsertCTHD(mahd, mamh, sl))
                {
                    if (MessageBox.Show("Bạn có muốn thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        MessageBox.Show("Thêm thành công");
                        ViewCtHoaDon();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lôi thêm dữ liệu");
                return;
            }
        }
    }
}
