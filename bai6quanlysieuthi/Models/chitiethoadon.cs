namespace bai6quanlysieuthi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("chitiethoadon")]
    public partial class chitiethoadon
    {
        [Key]
        public int stt { get; set; }

        [StringLength(20)]
        public string mahoadon { get; set; }

        [StringLength(20)]
        public string mamathang { get; set; }

        public int soluong { get; set; }

        public float dongi