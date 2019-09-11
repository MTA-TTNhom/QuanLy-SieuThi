using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bai6quanlysieuthi.Controller;

namespace bai6quanlysieuthi.Views
{
    public partial class NhanVien: Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
#region menu Nhân viên
        private void menuTrangChu_Click(object sender, EventArgs e)
        {
            TrangChu f = new TrangChu();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

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

        private void hướngDấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDan f = new HuongDan();
            f.ShowDialog();
        }
        #endregion

        #region Nhân viên
#region View Nhân viên
        private void btnView_NV_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewNhanVien();

        }
        void ViewNhanVien()
        {
            dgvNhanVien.DataSource = NhanVienController.Instance.XemNhanVien();
            dgvNhanVien.Columns["ma"].HeaderText = @"Mã";
            dgvNhanVien.Columns["ma"].Width = 45;
            dgvNhanVien.Columns["ten"].HeaderText = @"Họ và tên";
            dgvNhanVien.Columns["ten"].Width = 100;
            dgvNhanVien.Columns["ngaysinh"].HeaderText = @"Ngày sinh";
            dgvNhanVien.Columns["ngaysinh"].Width = 80;
            dgvNhanVien.Columns["diachi"].HeaderText = @"Địa chỉ";
            dgvNhanVien.Columns["diachi"].Width = 120;
            dgvNhanVien.Columns["sodienthoai"].HeaderText = @"Số điện thoại";
            dgvNhanVien.Columns["sodienthoai"].Width = 80;
            dgvNhanVien.Columns["machucvu"].HeaderText = @"Mã chức vụ";
            dgvNhanVien.Columns["machucvu"].Width = 60;
            dgvNhanVien.Columns["taikhoan"].HeaderText = @"Tài khoản";
            dgvNhanVien.Columns["taikhoan"].Width = 120;
            dgvNhanVien.Columns["matkhau"].HeaderText = @"Mật khẩu";
            dgvNhanVien.Columns["matkhau"].Width = 100;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            dtpNgaySinh.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            txtSoDienThoai.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            cbMaChucVu.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            txtTaiKhoan.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
            txtMatKhau.Text = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
        }
        #endregion

#region thêm nhân viên
        private void btnInsert_NV_Click(object sender, EventArgs e)
        {

        }
        #endregion
#region   sửa nhân viên
        private void btnUpdate_NV_Click(object sender, EventArgs e)
        {
            
        }
        #endregion
#region xóa nhân viên
        private void btnDelete_NV_Click(object sender, EventArgs e)
        {
            
        }
#endregion

        private void btnExit_NV_Click(object sender, EventArgs e)
        {
           
        }
#region
        private void btnSearch_NV_Click(object sender, EventArgs e)
        {
            
        }
#endregion
        #endregion

        #region phiếu giao ca
        #region View phiếu giao ca
        private void btnView_PGC_Click(object sender, EventArgs e)
        {
          
        }
        void ViewGiaoCa()
        {
          
        }

        private void dgvPhieuGC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSearch_NV_Click_1(object sender, EventArgs e)
        {
            if (cbSearch.Text == @"Mã nhân viên")
            {
                if (txtSearch.Text != "")
                {
                    dgvNhanVien.DataSource = NhanVienController.Instance.SearchNhanVien(txtSearch.Text);
                }
            }
            else if (cbSearch.Text == @"Số điện thoại")
            {
                if (txtSearch.Text != "")
                {
                    dgvNhanVien.DataSource = NhanVienController.Instance.SearchNhanVien1(txtSearch.Text);
                }
            }
        }
        #endregion

        #region theem phiếu giao ca

    }
}
