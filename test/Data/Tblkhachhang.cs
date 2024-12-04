using System;
using System.Collections.Generic;

namespace test.Data
{
    public partial class Tblkhachhang
    {
        public Tblkhachhang()
        {
            Tblyeucauhotrokythuats = new HashSet<Tblyeucauhotrokythuat>();
        }

        public string MaKhachHang { get; set; } = null!;
        public string? HoKhachHang { get; set; }
        public string? TenKhachHang { get; set; }
        public string? Email { get; set; }
        public string? SoDienThoai { get; set; }
        public string? TenCongTy { get; set; }
        public string? MaSoThue { get; set; }
        public string? PhanMem { get; set; }
        public string? Website { get; set; }
        public string? Password { get; set; }
        public DateTime? NgayKichHoat { get; set; }
        public bool? TrangThai { get; set; }

        public virtual ICollection<Tblyeucauhotrokythuat> Tblyeucauhotrokythuats { get; set; }
    }
}
