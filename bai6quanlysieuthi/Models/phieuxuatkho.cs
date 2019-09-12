namespace bai6quanlysieuthi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("phieuxuatkho")]
    public partial class phieuxuatkho
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public phieuxuatkho()
        //{
        //    chitietphieuxuats = new HashSet<chitietphieuxuat>();
        //}

        [Key]
        [StringLength(20)]
        public string ma { get; set; }

        public DateTime? ngayxuat { get; set; }

        public float tonggiatri { get; set; }

       

        public phieuxuatkho(string ma,  DateTime ngayxuat, float tonggiatri, )
        {
            this.ma = ma;
           
            this.ngayxuat = ngayxuat;
            this.tonggiatri = tonggiatri;
           
        }

       
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<chitietphieuxuat> chitietphieuxuats { get; set; }

        //public virtual khohang khohang { get; set; }

        //public virtual nhanvien nhanvien { get; set; }

        //public virtual quayhang quayhang { get; set; }
    }
}
