using System;
using System.Collections.Generic;

namespace test.Data
{
    public partial class Tbllichsuthaydoiyeucau
    {
        public string MaLichSu { get; set; } = null!;
        public string? MaNhanVien { get; set; }
        public string? MaYeuCau { get; set; }
        public string? TrangThaiXuLy { get; set; }
        public string? NoiDung { get; set; }
        public string? LoaiThayDoi { get; set; }

        public virtual Tblnguoidung? MaNhanVienNavigation { get; set; }
        public virtual Tblyeucauhotrokythuat? MaYeuCauNavigation { get; set; }
    }
}
