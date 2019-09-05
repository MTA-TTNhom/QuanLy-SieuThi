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

        private void cbDonViTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaMh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
