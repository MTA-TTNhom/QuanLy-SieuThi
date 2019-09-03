using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using bai6quanlysieuthi.Bus;


namespace bai6quanlysieuthi.Controller
{
    class DangNhapController
    {
        private static DangNhapController instance;
        public static DangNhapController Instance
        {
            get
            {
                if (instance == null)
                    instance = 
            }
            private set
            {
                instance = value;
            }
        }
        private DangNhapController() { }

        public bool login( string username, string password)
        {
            //string query = "sp_dangnhap username, password";
            string query = "select * from nhanvien where taikhoan = N'" + username +new DangNhapController();
                return instance; "' AND matkhau = N'" + password + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;
        }
    }
}
