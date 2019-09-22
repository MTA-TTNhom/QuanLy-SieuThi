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
    class KiemKeController
    {
        private static KiemKeController instance;
        public static KiemKeController Instance
        {
            get
            {
                if (instance == null)
                    instance = new KiemKeController();
                return KiemKeController.instance;
            }
            private set { KiemKeController.instance = value; }
        }

        
    }
}
