using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace test.Data
{
    public partial class Tech_Support_TicketContext : DbContext
    {
        public Tech_Support_TicketContext()
        {
        }

        public Tech_Support_TicketContext(DbContextOptions<Tech_Support_TicketContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tblchucnang> Tblchucnangs { get; set; } = null!;
        public virtual DbSet<Tblkhachhang> Tblkhachhangs { get; set; } = null!;
        public virtual DbSet<Tbllichsuthaydoiyeucau> Tbllichsuthaydoiyeucaus { get; set; } = null!;
        public virtual DbSet<Tblnguoidung> Tblnguoidungs { get; set; } = null!;
        public virtual DbSet<Tblphongban> Tblphongbans { get; set; } = null!;
        public virtual DbSet<Tblquyen> Tblquyens { get; set; } = null!;
        public virtual DbSet<Tblyeucauhotrokythuat> Tblyeucauhotrokythuats { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=159.223.53.233;Initial Catalog=Tech_Support_Ticket;Persist Security Info=True;User ID=sa;Password=Thuctap123!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tblchucnang>(entity =>
            {
                entity.HasKey(e => e.MaChucNang)
                    .HasName("PK_TBLCHUCNANG");

                entity.ToTable("tblchucnang");

                entity.Property(e => e.MaChucNang)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ma_chuc_nang");

                entity.Property(e => e.TenChucNang)
                    .HasMaxLength(100)
                    .HasColumnName("ten_chuc_nang");
            });

            modelBuilder.Entity<Tblkhachhang>(entity =>
            {
                entity.HasKey(e => e.MaKhachHang)
                    .HasName("PK_TBLKHACHHANG");

                entity.ToTable("tblkhachhang");

                entity.Property(e => e.MaKhachHang)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ma_khach_hang");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.HoKhachHang)
                    .HasMaxLength(50)
                    .HasColumnName("ho_khach_hang");

                entity.Property(e => e.MaSoThue)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ma_so_thue");

                entity.Property(e => e.NgayKichHoat)
                    .HasColumnType("datetime")
                    .HasColumnName("ngay_kich_hoat");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.PhanMem)
                    .HasMaxLength(100)
                    .HasColumnName("phan_mem");

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("so_dien_thoai");

                entity.Property(e => e.TenCongTy)
                    .HasMaxLength(100)
                    .HasColumnName("ten_cong_ty");

                entity.Property(e => e.TenKhachHang)
                    .HasMaxLength(10)
                    .HasColumnName("ten_khach_hang");

                entity.Property(e => e.TrangThai).HasColumnName("trang_thai");

                entity.Property(e => e.Website)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("website");
            });

            modelBuilder.Entity<Tbllichsuthaydoiyeucau>(entity =>
            {
                entity.HasKey(e => e.MaLichSu)
                    .HasName("PK_TBLLICHSUTHAYDOIYEUCAU");

                entity.ToTable("tbllichsuthaydoiyeucau");

                entity.Property(e => e.MaLichSu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ma_lich_su");

                entity.Property(e => e.LoaiThayDoi)
                    .HasMaxLength(50)
                    .HasColumnName("loai_thay_doi");

                entity.Property(e => e.MaNhanVien)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ma_nhan_vien");

                entity.Property(e => e.MaYeuCau)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ma_yeu_cau");

                entity.Property(e => e.NoiDung)
                    .HasMaxLength(1000)
                    .HasColumnName("noi_dung");

                entity.Property(e => e.TrangThaiXuLy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("trang_thai_xu_ly");

                entity.HasOne(d => d.MaNhanVienNavigation)
                    .WithMany(p => p.Tbllichsuthaydoiyeucaus)
                    .HasForeignKey(d => d.MaNhanVien)
                    .HasConstraintName("FK_TBLLICHS_REFERENCE_TBLNGUOI");

                entity.HasOne(d => d.MaYeuCauNavigation)
                    .WithMany(p => p.Tbllichsuthaydoiyeucaus)
                    .HasForeignKey(d => d.MaYeuCau)
                    .HasConstraintName("FK_TBLLICHS_REFERENCE_TBLYEUCA");
            });

            modelBuilder.Entity<Tblnguoidung>(entity =>
            {
                entity.HasKey(e => e.MaNguoiDung)
                    .HasName("PK_TBLNGUOIDUNG");

                entity.ToTable("tblnguoidung");

                entity.Property(e => e.MaNguoiDung)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ma_nguoi_dung");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.HoNguoiDung)
                    .HasMaxLength(50)
                    .HasColumnName("ho_nguoi_dung");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("so_dien_thoai");

                entity.Property(e => e.TenNguoiDung)
                    .HasMaxLength(10)
                    .HasColumnName("ten_nguoi_dung");

                entity.Property(e => e.TrangThai).HasColumnName("trang_thai");

                entity.HasMany(d => d.MaPhongBans)
                    .WithMany(p => p.MaNguoiDungs)
                    .UsingEntity<Dictionary<string, object>>(
                        "TblnguoidungPhongban",
                        l => l.HasOne<Tblphongban>().WithMany().HasForeignKey("MaPhongBan").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_TBLNGUOI_REFERENCE_TBLPHONG"),
                        r => r.HasOne<Tblnguoidung>().WithMany().HasForeignKey("MaNguoiDung").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_TBLNGUOI_REFERENCE_TBLNGUOI"),
                        j =>
                        {
                            j.HasKey("MaNguoiDung", "MaPhongBan").HasName("PK_TBLNGUOIDUNG_PHONGBAN");

                            j.ToTable("tblnguoidung_phongban");

                            j.IndexerProperty<string>("MaNguoiDung").HasMaxLength(10).IsUnicode(false).HasColumnName("ma_nguoi_dung");

                            j.IndexerProperty<string>("MaPhongBan").HasMaxLength(10).IsUnicode(false).HasColumnName("ma_phong_ban");
                        });
            });

            modelBuilder.Entity<Tblphongban>(entity =>
            {
                entity.HasKey(e => e.MaPhongBan)
                    .HasName("PK_TBLPHONGBAN");

                entity.ToTable("tblphongban");

                entity.Property(e => e.MaPhongBan)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ma_phong_ban");

                entity.Property(e => e.TenPhongBan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ten_phong_ban");

                entity.Property(e => e.TrangThai).HasColumnName("trang_thai");
            });

            modelBuilder.Entity<Tblquyen>(entity =>
            {
                entity.HasKey(e => e.MaQuyen)
                    .HasName("PK_TBLQUYEN");

                entity.ToTable("tblquyen");

                entity.Property(e => e.MaQuyen)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ma_quyen");

                entity.Property(e => e.MaChucNang)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ma_chuc_nang");

                entity.Property(e => e.TenQuyen)
                    .HasMaxLength(50)
                    .HasColumnName("ten_quyen");

                entity.HasOne(d => d.MaChucNangNavigation)
                    .WithMany(p => p.Tblquyens)
                    .HasForeignKey(d => d.MaChucNang)
                    .HasConstraintName("FK_TBLQUYEN_REFERENCE_TBLCHUCN");

                entity.HasMany(d => d.MaPhongBans)
                    .WithMany(p => p.MaQuyens)
                    .UsingEntity<Dictionary<string, object>>(
                        "TblquyenPhongban",
                        l => l.HasOne<Tblphongban>().WithMany().HasForeignKey("MaPhongBan").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_TBLQUYEN_REFERENCE_TBLPHONG"),
                        r => r.HasOne<Tblquyen>().WithMany().HasForeignKey("MaQuyen").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_TBLQUYEN_REFERENCE_TBLQUYEN"),
                        j =>
                        {
                            j.HasKey("MaQuyen", "MaPhongBan").HasName("PK_TBLQUYEN_PHONGBAN");

                            j.ToTable("tblquyen_phongban");

                            j.IndexerProperty<string>("MaQuyen").HasMaxLength(10).IsUnicode(false).HasColumnName("ma_quyen");

                            j.IndexerProperty<string>("MaPhongBan").HasMaxLength(10).IsUnicode(false).HasColumnName("ma_phong_ban");
                        });
            });

            modelBuilder.Entity<Tblyeucauhotrokythuat>(entity =>
            {
                entity.HasKey(e => e.MaYeuCau)
                    .HasName("PK_TBLYEUCAUHOTROKYTHUAT");

                entity.ToTable("tblyeucauhotrokythuat");

                entity.Property(e => e.MaYeuCau)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ma_yeu_cau");

                entity.Property(e => e.MaKhachHang)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ma_khach_hang");

                entity.Property(e => e.MaPhongBan)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ma_phong_ban");

                entity.Property(e => e.NgayTiepNhan)
                    .HasColumnType("datetime")
                    .HasColumnName("ngay_tiep_nhan");

                entity.Property(e => e.NgayXuLy)
                    .HasColumnType("datetime")
                    .HasColumnName("ngay_xu_ly");

                entity.Property(e => e.NoiDungYeuCau)
                    .HasMaxLength(1000)
                    .HasColumnName("noi_dung_yeu_cau");

                entity.Property(e => e.TenYeuCau)
                    .HasMaxLength(100)
                    .HasColumnName("ten_yeu_cau");

                entity.Property(e => e.TrangThaiXuLy)
                    .HasMaxLength(30)
                    .HasColumnName("trang_thai_xu_ly");

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.Tblyeucauhotrokythuats)
                    .HasForeignKey(d => d.MaKhachHang)
                    .HasConstraintName("FK_TBLYEUCA_REFERENCE_TBLKHACH");

                entity.HasOne(d => d.MaPhongBanNavigation)
                    .WithMany(p => p.Tblyeucauhotrokythuats)
                    .HasForeignKey(d => d.MaPhongBan)
                    .HasConstraintName("FK_TBLYEUCA_REFERENCE_TBLPHONG");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
