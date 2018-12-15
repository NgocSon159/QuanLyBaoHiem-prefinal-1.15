namespace QuanLyBaoHiem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietThanhPhanHopDong")]
    public partial class ChiTietThanhPhanHopDong
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MaHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MaKH { get; set; }

        public bool? Status { get; set; }

        public virtual HopDong HopDong { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
