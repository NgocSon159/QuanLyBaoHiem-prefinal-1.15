namespace QuanLyBaoHiem.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLBHContext : DbContext
    {
        public QLBHContext()
            : base("name=QLBHContextIP")
        {
        }

        public virtual DbSet<CapDo> CapDoes { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<ChuKyThanhToan> ChuKyThanhToans { get; set; }
        public virtual DbSet<GoiHopDong> GoiHopDongs { get; set; }
        public virtual DbSet<HopDong> HopDongs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NguoiThan> NguoiThans { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<ChiTietThanhPhanHopDong> ChiTietThanhPhanHopDongs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CapDo>()
                .Property(e => e.MaCD)
                .IsUnicode(false);

            modelBuilder.Entity<ChucVu>()
                .Property(e => e.MaCV)
                .IsUnicode(false);

            modelBuilder.Entity<ChuKyThanhToan>()
                .Property(e => e.MaChuKy)
                .IsUnicode(false);

            modelBuilder.Entity<ChuKyThanhToan>()
                .Property(e => e.ChuKyDong)
                .IsUnicode(false);

            modelBuilder.Entity<GoiHopDong>()
                .Property(e => e.MaGoiHD)
                .IsUnicode(false);

            modelBuilder.Entity<GoiHopDong>()
                .Property(e => e.MucPhi)
                .HasPrecision(19, 3);

            modelBuilder.Entity<GoiHopDong>()
                .Property(e => e.GiaTriBaoHiem)
                .HasPrecision(19, 3);

            modelBuilder.Entity<HopDong>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<HopDong>()
                .Property(e => e.MaGoiHD)
                .IsUnicode(false);

            modelBuilder.Entity<HopDong>()
                .Property(e => e.MaChuKy)
                .IsUnicode(false);

            modelBuilder.Entity<HopDong>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<HopDong>()
                .Property(e => e.MaKHChinh)
                .IsUnicode(false);

            modelBuilder.Entity<HopDong>()
                .HasMany(e => e.ChiTietThanhPhanHopDongs)
                .WithRequired(e => e.HopDong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaCD)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Sdt)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HopDongs)
                .WithOptional(e => e.KhachHang)
                .HasForeignKey(e => e.MaKHChinh);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.ChiTietThanhPhanHopDongs)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.NguoiThans)
                .WithOptional(e => e.KhachHang)
                .HasForeignKey(e => e.MaKH);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.NguoiThans1)
                .WithOptional(e => e.KhachHang1)
                .HasForeignKey(e => e.MaKHRieng);

            modelBuilder.Entity<NguoiThan>()
                .Property(e => e.MaNT)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiThan>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiThan>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiThan>()
                .Property(e => e.MaKHRieng)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiThan>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaCV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Sdt)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNVQuanLi)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.NhanVien1)
                .WithOptional(e => e.NhanVien2)
                .HasForeignKey(e => e.MaNVQuanLi);

            modelBuilder.Entity<ChiTietThanhPhanHopDong>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietThanhPhanHopDong>()
                .Property(e => e.MaKH)
                .IsUnicode(false);
        }
    }
}
