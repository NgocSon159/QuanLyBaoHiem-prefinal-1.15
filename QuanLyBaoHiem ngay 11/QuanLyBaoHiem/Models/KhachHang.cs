namespace QuanLyBaoHiem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            HopDongs = new HashSet<HopDong>();
            ChiTietThanhPhanHopDongs = new HashSet<ChiTietThanhPhanHopDong>();
            NguoiThans = new HashSet<NguoiThan>();
            NguoiThans1 = new HashSet<NguoiThan>();
        }

        [Key]
        [StringLength(50)]
        public string MaKH { get; set; }

        [StringLength(50)]
        public string MaCD { get; set; }

        [StringLength(50)]
        public string TenKH { get; set; }

        public DateTime? NgaySinh { get; set; }

        public bool? GioiTinh { get; set; }

        [StringLength(150)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string Sdt { get; set; }

        [StringLength(50)]
        public string CMND { get; set; }

        public byte[] HinhAnh { get; set; }

        public bool? Status { get; set; }

        public virtual CapDo CapDo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HopDong> HopDongs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietThanhPhanHopDong> ChiTietThanhPhanHopDongs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NguoiThan> NguoiThans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NguoiThan> NguoiThans1 { get; set; }
    }
}
