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
    class CtHoaDonController
    {
        private static CtHoaDonController instance;
        public static CtHoaDonController Instance
        {
            get
            {
                if (instance == null)
                    instance = new CtHoaDonController();
                return CtHoaDonController.instance;
            }
            private set { CtHoaDonController.instance = value; }
        }

        private CtHoaDonController() { }

        
    }
}
