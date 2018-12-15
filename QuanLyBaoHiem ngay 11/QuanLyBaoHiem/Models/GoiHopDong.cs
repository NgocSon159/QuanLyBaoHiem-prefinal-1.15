namespace QuanLyBaoHiem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoiHopDong")]
    public partial class GoiHopDong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoiHopDong()
        {
            HopDongs = new HashSet<HopDong>();
        }

        [Key]
        [StringLength(50)]
        public string MaGoiHD { get; set; }

        public decimal? MucPhi { get; set; }

        public decimal? GiaTriBaoHiem { get; set; }

        public int? ThoiHanBaoHiem { get; set; }

        public int? ThoiHanDongPhi { get; set; }

        public bool? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HopDong> HopDongs { get; set; }
    }
}
