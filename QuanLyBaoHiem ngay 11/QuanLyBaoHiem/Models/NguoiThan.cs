namespace QuanLyBaoHiem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiThan")]
    public partial class NguoiThan
    {
        [Key]
        [StringLength(50)]
        public string MaNT { get; set; }

        [StringLength(50)]
        public string MaKH { get; set; }

        [StringLength(50)]
        public string TenNT { get; set; }

        public DateTime? NgaySinh { get; set; }

        public bool? GioiTinh { get; set; }

        [StringLength(150)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string CMND { get; set; }

        [StringLength(50)]
        public string MaKHRieng { get; set; }

        public bool? Status { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual KhachHang KhachHang1 { get; set; }
    }
}
