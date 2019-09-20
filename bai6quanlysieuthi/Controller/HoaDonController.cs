using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai6quanlysieuthi.Models;
using System.Data;
using bai6quanlysieuthi.Bus;
namespace bai6quanlysieuthi.Controller
{
    class HoaDonController
    {
        private static HoaDonController instance;
        public static HoaDonController Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonController();
                return HoaDonController.instance;
            }
            private set { HoaDonController.instance = value; }
        }

       

        
        public bool UpdateHoaDon(string ma, DateTime ngaylap, string manv, string makh)
        {
            string query = string.Format("update hoadon set ngaylap=N'{0}',manhanvien=N'{1}',makhachhang=N'{2}' where ma=N'{3}'", ngaylap, manv, makh, ma);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        //xóa hóa đơn
        public bool DeleteHoaDon(string ma)
        {
            string query = string.Format("delete hoadon where ma=N'{0}'", ma);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // tìm kiếm  hóa đon
        public List<hoadon> SearchHd(string ma)
        {
            List<hoadon> list = new List<hoadon>();
            string query = string.Format("select * from hoadon hd where hd.ma like N'%{0}%' ", ma);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow i in data.Rows)
            {
                hoadon ct = new hoadon(i);
                list.Add(ct);
            }
            return list;
        }

        public List<hoadon> SearchHd1(string manhanvien)
        {
            List<hoadon> list = new List<hoadon>();
            string query = string.Format("select * from hoadon hd inner join nhanvien nv on hd.manhanvien=nv.ma where nv.ma like N'%{0}%' ", manhanvien);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow i in data.Rows)
            {
                hoadon ct = new hoadon(i);
                list.Add(ct);
            }
            return list;
        }
        public List<hoadon> SearchHd2(string makhachhang)
        {
            List<hoadon> list = new List<hoadon>();
            string query = string.Format("select * from hoadon hd inner join khachhang kh on hd.makhachhang=kh.ma where kh.ma like N'%{0}%' ", makhachhang);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow i in data.Rows)
            {
                hoadon ct = new hoadon(i);
                list.Add(ct);
            }
            return list;
        }
    }
}
