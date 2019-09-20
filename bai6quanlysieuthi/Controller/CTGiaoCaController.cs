using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai6quanlysieuthi.Bus;
using bai6quanlysieuthi.Models;
using System.Data;

namespace bai6quanlysieuthi.Controller
{
    class CTGiaoCaController
    {
        public static CTGiaoCaController instance;
        public static CTGiaoCaController Instance
        {
            get
            {
                if (instance == null)
                    instance = new CTGiaoCaController();
                return CTGiaoCaController.instance;
            }
            private set { CTGiaoCaController.instance = value; }
        }

        {
            string query = string.Format("delete chitietphieugiaoca where stt={0}",stt);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // tìm kiếm chi tiết phiếu giao ca
        public List<chitietphieugiaoca> SearchCtGiaoCa(string magiaoca, string mamathang)
        {
            List<chitietphieugiaoca> list = new List<chitietphieugiaoca>();
            string query = string.Format("select * from chitietphieugiaoca where magiaoca like N'%{0}%' and mamathang like N'%{1}%'", magiaoca, mamathang);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow i in data.Rows)
            {
                chitietphieugiaoca ct = new chitietphieugiaoca(i);
                list.Add(ct);
            }
            return list;
        }
    }
}
