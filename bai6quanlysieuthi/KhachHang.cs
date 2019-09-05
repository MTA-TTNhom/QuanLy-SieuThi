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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
