using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6quanlysieuthi.Bus
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return DataProvider.instance;
            }
            private set
            {
                DataProvider.instance = value;
            }
        }
        private DataProvider() { }

        private string connectionSTR = "Data Source=THANH-HOANG-THU\\THANH-HOANG-THU;Initial Catalog=banhangsieuthi;Integrated Security=True";
    }
}
