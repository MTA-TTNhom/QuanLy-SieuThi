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
    }
}
