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

        public CTGiaoCaController() { }
        // xem chi tiết phiếu giao ca
        
    }
}
