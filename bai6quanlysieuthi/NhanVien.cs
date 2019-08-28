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
            
        }

        private void menuKhachHang_Click(object sender, EventArgs e)
        {
            
        }

        private void menuHangHoa_Click(object sender, EventArgs e)
        {
         
        }

        private void hướngDấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
        }
        #endregion

        #region Nhân viên
#region View Nhân viên
        private void btnView_NV_Click(object sender, EventArgs e)
        {
          
        }
        void ViewNhanVien()
        {
          
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
