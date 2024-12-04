using System;
using System.Collections.Generic;

namespace test.Data
{
    public partial class Tblnguoidung
    {
        public Tblnguoidung()
        {
            Tbllichsuthaydoiyeucaus = new HashSet<Tbllichsuthaydoiyeucau>();
            MaPhongBans = new HashSet<Tblphongban>();
        }

        public string MaNguoiDung { get; set; } = null!;
        public string? HoNguoiDung { get; set; }
        public string? TenNguoiDung { get; set; }
        public string? Email { get; set; }
        public string? SoDienThoai { get; set; }
        public string? Password { get; set; }
        public bool? TrangThai { get; set; }

        public virtual ICollection<Tbllichsuthaydoiyeucau> Tbllichsuthaydoiyeucaus { get; set; }

        public virtual ICollection<Tblphongban> MaPhongBans { get; set; }
    }
}
