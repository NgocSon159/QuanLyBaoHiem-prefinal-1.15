namespace QuanLyBaoHiem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HopDong")]
    public partial class HopDong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HopDong()
        {
            ChiTietThanhPhanHopDongs = new HashSet<ChiTietThanhPhanHopDong>();
        }

        [Key]
        [StringLength(50)]
        public string MaHD { get; set; }

        [StringLength(50)]
        public string MaGoiHD { get; set; }

        [StringLength(50)]
        public string MaChuKy { get; set; }

        [StringLength(50)]
        public string MaNV { get; set; }

        [StringLength(50)]
        public string MaKHChinh { get; set; }

        public DateTime? NgayHieuLuc { get; set; }

        public bool? Status { get; set; }

        public virtual ChuKyThanhToan ChuKyThanhToan { get; set; }

        public virtual GoiHopDong GoiHopDong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietThanhPhanHopDong> ChiTietThanhPhanHopDongs { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
