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
    public partial class HuongDan: Form
    {
        public HuongDan()
        {
            InitializeComponent();
        }

        private void HuongDan_Load(object sender, EventArgs e)
        {
// day la form huong dan 

        }
        /*//
         * 
         * 
         * ewqewqyeqwiueqwuiscsddds
         * fsdf
         * df
         * sdf
         * dsf
         * dsf
         * ds
         * fd
         * saf
         * ds
         * tgb4
         * tregt
         *  n5n 
         *  yju7mi
         *  6i
         *  6i
         *  yhghj
         *  h
         *  hgj
         *  hg
         *  h
         *  h
         *  
         *  
         *  
         * /*/
        private void button1_Click(object sender, EventArgs e)
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
