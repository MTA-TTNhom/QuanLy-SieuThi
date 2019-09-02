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
    public partial class HangHoa : Form
    {
        public HangHoa()
        {
            InitializeComponent();
        }
        #region View Mặt hàng

        private void btnView_MH_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewMatHang();
        }
        void ViewMatHang()
        {
            dgvMatHang.DataSource = MatHangController.Instance.XemMatHang();
            dgvMatHang.Columns["ma"].HeaderText = @"Mã";
            dgvMatHang.Columns["ma"].Width = 45;
            dgvMatHang.Columns["ten"].HeaderText = @"Tên mặt hàng";
            dgvMatHang.Columns["ten"].Width = 80;
            dgvMatHang.Columns["loaimathang"].HeaderText = @"Loại mặt hàng";
            dgvMatHang.Columns["loaimathang"].Width = 60;
            dgvMatHang.Columns["donvitinh"].HeaderText = @"Đơn vị tính";
            dgvMatHang.Columns["donvitinh"].Width = 60;
            dgvMatHang.Columns["maquay"].HeaderText = @"Mã quầy";
            dgvMatHang.Columns["maquay"].Width = 60;

            dgvMatHang.Columns["manhacc"].Width = 60;
            dgvMatHang.Columns["gia"].Width = 60;
        }
        private void dgvMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHang.Text = dgvMatHang.CurrentRow.Cells[0].Value.ToString();
            txtTenHang.Text = dgvMatHang.CurrentRow.Cells[1].Value.ToString();
            cbLoai.Text = dgvMatHang.CurrentRow.Cells[2].Value.ToString();
            cbDonViTinh.Text = dgvMatHang.CurrentRow.Cells[3].Value.ToString();
            cbMaQuay.Text = dgvMatHang.CurrentRow.Cells[4].Value.ToString();
            txtMaNCC.Text = dgvMatHang.CurrentRow.Cells[5].Value.ToString();
            txtGiaMh.Text = dgvMatHang.CurrentRow.Cells[6].Value.ToString();
        }
        #endregion
        #region thêm mặt hàng
        private void btnInsert_MH_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "" || txtTenHang.Text == "" || cbDonViTinh.Text == "" || cbLoai.Text == "" || txtGiaMh.Text == "" || cbMaQuay.Text == "" || txtMaNCC.Text == "")
            {
                if (txtMaHang.Text == "")
                    errorProvider1.SetError(txtMaHang, "Chưa có mã hàng");
                if (txtTenHang.Text == "")
                    errorProvider1.SetError(txtTenHang, "Chưa có tên hàng");
                if (cbDonViTinh.Text == "")
                    errorProvider1.SetError(cbLoai, "Chưa phân loại hàng");
                if (cbDonViTinh.Text == "")
                    errorProvider1.SetError(cbDonViTinh, "Chưa có đơn vị tính");
                if (cbMaQuay.Text == "")
                    errorProvider1.SetError(cbMaQuay, "Chưa có mã quầy");
                if (txtMaNCC.Text == "")
                    errorProvider1.SetError(txtMaNCC, "Chưa có nhà cung cấp");
                if (txtGiaMh.Text == "")
                    errorProvider1.SetError(txtGiaMh, "Chưa có giá mặt hàng");
                MessageBox.Show("Nhập thông tin đầy đủ");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaHang.Text;
                string ten = txtTenHang.Text;
                string loai = cbLoai.Text;
                string donvt = cbDonViTinh.Text;
                string maquay = cbMaQuay.Text;
                string mancc = txtMaNCC.Text;
                float gia = (float)Convert.ToDouble(txtGiaMh.Text);

                if (MessageBox.Show("Bạn có muốn thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (MatHangController.Instance.InsertMatHang(ma, ten, loai, donvt, maquay, mancc, gia))
                    {
                        MessageBox.Show("Thêm thành công");
                        ViewMatHang();
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
        private void btnDelete_MH_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "")
            {
                errorProvider1.SetError(txtMaHang, "Chưa có mã hàng");
                MessageBox.Show("Nhập vào mã cần xóa");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa hay không", "xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (MatHangController.Instance.DeleteMatHang(txtMaHang.Text))
                {
                    MessageBox.Show("Xóa thành công");
                    ViewMatHang();
                }
            }
            else
            {
                MessageBox.Show("Không thành công!");
            }
        }
        private void btnExit_MH_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSearch_MH_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "" && txtTenHang.Text == "" && cbLoai.Text == "" && cbMaQuay.Text == "" && txtMaNCC.Text == "")
            {
                if (txtMaHang.Text == "")
                    errorProvider1.SetError(txtMaHang, "Chưa có mã hàng cần tìm");

                if (txtTenHang.Text == "")
                    errorProvider1.SetError(txtTenHang, "Chưa có tên hàng cần tìm");

                if (cbLoai.Text == "")
                    errorProvider1.SetError(cbLoai, "Chưa có loại sản phẩm cần tìm");

                if (cbMaQuay.Text == "")
                    errorProvider1.SetError(cbMaQuay, "Chưa có mã quầy cần tìm");

                if (txtMaNCC.Text == "")
                    errorProvider1.SetError(txtMaNCC, "Chưa có mã nhà cung cấp cần tìm");

                MessageBox.Show("Nhập vào thông tin cần tìm");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            dgvMatHang.DataSource = MatHangController.Instance.SearchMatHang(txtMaHang.Text, txtTenHang.Text, cbLoai.Text, cbMaQuay.Text, txtMaNCC.Text);

        }
    }
}
