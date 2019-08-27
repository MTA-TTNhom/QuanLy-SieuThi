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

        private void btnUpdate_CTHD_Click(object sender, EventArgs e)
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
                int stt = (int)Convert.ToInt32(txtSTT.Text);
                string mahd = txtMaHoaDon.Text;
                string mamh = cbMaMatHang.Text;
                int sl = (int)Convert.ToInt32(txtSoLuong.Text);
                if (txtMaHoaDon.Text == "" || cbMaMatHang.Text == "" || txtSoLuong.Text == "")
                {
                    MessageBox.Show("Phải điền thông tin đầy đủ");
                    return;
                }
                if (CtHoaDonController.Instance.UpdateCTHD(stt, mahd, mamh, sl))
                {
                    if (MessageBox.Show("Bạn có muốn sửa hay không", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        MessageBox.Show("Sửa thành công");
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

        private void btnDelete_CTHD_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int stt = (int)Convert.ToInt32(txtSTT.Text);

            if (MessageBox.Show("Bạn có muốn xóa hay không", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (CtHoaDonController.Instance.DeleteCTHD(stt))
                {
                    MessageBox.Show("Xóa thành công!");
                    ViewCtHoaDon();
                }
            }
            else
            {
                MessageBox.Show("Không thành công!");
            }


            private void btnExit_CTHD_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void btnSearch_CTHD_Click(object sender, EventArgs e)
            {
                if (cbSearchCTHD.Text == @"Mã hóa đơn")
                {
                    if (txtSearchCTHD.Text != "")
                    {
                        dgvCtHoaDon.DataSource = CtHoaDonController.Instance.SearchCtHd(txtSearchCTHD.Text);
                    }
                }
                else if (cbSearchCTHD.Text == @"Mã mặt hàng")
                {
                    if (txtSearchCTHD.Text != "")
                    {
                        dgvCtHoaDon.DataSource = CtHoaDonController.Instance.SearchCtHd1(txtSearchCTHD.Text);
                    }
                }
            }

            private void dgvCtHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                txtSTT.Text = dgvCtHoaDon.CurrentRow.Cells[0].Value.ToString();
                txtMaHoaDon.Text = dgvCtHoaDon.CurrentRow.Cells[1].Value.ToString();
                cbMaMatHang.Text = dgvCtHoaDon.CurrentRow.Cells[2].Value.ToString();
                txtSoLuong.Text = dgvCtHoaDon.CurrentRow.Cells[3].Value.ToString();
                txtDonGia.Text = dgvCtHoaDon.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void btnInsert_CTHD_Click_1(object sender, EventArgs e)
        {

        }

        private void txtMaHoaDon_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_CTHD_Click(object sender, EventArgs e)
        {
            if (cbSearchCTHD.Text == @"Mã hóa đơn")
            {
                if (txtSearchCTHD.Text != "")
                {
                    dgvCtHoaDon.DataSource = CtHoaDonController.Instance.SearchCtHd(txtSearchCTHD.Text);
                }
            }
            else if (cbSearchCTHD.Text == @"Mã mặt hàng")
            {
                if (txtSearchCTHD.Text != "")
                {
                    dgvCtHoaDon.DataSource = CtHoaDonController.Instance.SearchCtHd1(txtSearchCTHD.Text);
                }
            }
        }
    }
}
