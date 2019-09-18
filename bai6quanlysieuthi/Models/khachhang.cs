namespace bai6quanlysieuthi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Data;
    [Table("khachhang")]
    public partial class khachhang
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public khachhang()
        //{
        //    khachmuahangs = new HashSet<khachmuahang>();
        //}

        }

        public khachhang(DataRow row)
        {
            this.ma = row["ma"].ToString();
            this.ten = row["ten"].ToString();
            this.diachi = row["diachi"].ToString();
            this.sodienthoai = row["sodienthoai"].ToString();
            try
            {
                this.uudai = (float)Convert.ToDouble(row["uudai"].ToString());
            }
            catch { }
        }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<khachmuahang> khachmuahangs { get; set; }
    }
}
