using System;
using System.Collections.Generic;

namespace test.Data
{
    public partial class Tblyeucauhotrokythuat
    {
        public Tblyeucauhotrokythuat()
        {
            Tbllichsuthaydoiyeucaus = new HashSet<Tbllichsuthaydoiyeucau>();
        }

        public string MaYeuCau { get; set; } = null!;
        public string? TenYeuCau { get; set; }
        public string? NoiDungYeuCau { get; set; }
        public DateTime? NgayTiepNhan { get; set; }
        public DateTime? NgayXuLy { get; set; }
        public string? TrangThaiXuLy { get; set; }
        public string? MaKhachHang { get; set; }
        public string? MaPhongBan { get; set; }

        public virtual Tblkhachhang? MaKhachHangNavigation { get; set; }
        public virtual Tblphongban? MaPhongBanNavigation { get; set; }
        public virtual ICollection<Tbllichsuthaydoiyeucau> Tbllichsuthaydoiyeucaus { get; set; }
    }
}
