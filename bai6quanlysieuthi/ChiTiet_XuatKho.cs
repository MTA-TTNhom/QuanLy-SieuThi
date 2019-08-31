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
    public partial class ChiTiet_XuatKho : Form
    {
        public ChiTiet_XuatKho()
        {
            InitializeComponent();
        }

#region View chi tiết xuất kho
        private void btnView_CTXK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewCtXuatKho();
        }
        void ViewCtXuatKho()
        {
            dgvCtXuatKho.DataSource = CtXuatKhoController.Instance.XemCtXuatKho();
            dgvCtXuatKho.Columns["stt"].Width = 45;
            dgvCtXuatKho.Columns["maxuat"].HeaderText = @"Mã xuất";
            dgvCtXuatKho.Columns["maxuat"].Width = 80;
            dgvCtXuatKho.Columns["mamathang"].HeaderText = @"Mã mặt hàng";
            dgvCtXuatKho.Columns["mamathang"].Width = 80;
            dgvCtXuatKho.Columns["soluong"].HeaderText = @"Số lượng";
            dgvCtXuatKho.Columns["soluong"].Width = 80;
            dgvCtXuatKho.Columns["dongia"].HeaderText = @"Đơng giá";
            dgvCtXuatKho.Columns["dongia"].Width = 80;
        }

#region thêm chi tiết phiếu xuất kho
        private void btnInsert_CTXK_Click(object sender, EventArgs e)
        {
            if (cbMaXuat.Text == "" || cbMaMatHang.Text == "" || txtSoLuong.Text == "")
            {
                if (cbMaXuat.Text == "")
                    errorProvider1.SetError(cbMaXuat, "Chưa có mã xuất");
                if (cbMaMatHang.Text == "")
                    errorProvider1.SetError(cbMaMatHang, "Chưa có mã mặt hàng");
                if (txtSoLuong.Text == "")
                    errorProvider1.SetError(txtSoLuong, "Chưa nhập số lượng");
                MessageBox.Show("Chưa có thông tin đầy đủ");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                int sl = (int)Convert.ToInt32(txtSoLuong.Text);
                if (MessageBox.Show("Bạn có muốn thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (CtXuatKhoController.Instance.InsertCtXuat(cbMaXuat.Text, cbMaMatHang.Text, sl))
                    {
                        MessageBox.Show("Thêm thành công");
                        ViewCtXuatKho();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }
        #endregion

    }
}
