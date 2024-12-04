using System;
using System.Collections.Generic;

namespace test.Data
{
    public partial class Tblphongban
    {
        public Tblphongban()
        {
            Tblyeucauhotrokythuats = new HashSet<Tblyeucauhotrokythuat>();
            MaNguoiDungs = new HashSet<Tblnguoidung>();
            MaQuyens = new HashSet<Tblquyen>();
        }

        public string MaPhongBan { get; set; } = null!;
        public string? TenPhongBan { get; set; }
        public bool? TrangThai { get; set; }

        public virtual ICollection<Tblyeucauhotrokythuat> Tblyeucauhotrokythuats { get; set; }

        public virtual ICollection<Tblnguoidung> MaNguoiDungs { get; set; }
        public virtual ICollection<Tblquyen> MaQuyens { get; set; }
    }
}
