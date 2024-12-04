using System;
using System.Collections.Generic;

namespace test.Data
{
    public partial class Tblquyen
    {
        public Tblquyen()
        {
            MaPhongBans = new HashSet<Tblphongban>();
        }

        public string MaQuyen { get; set; } = null!;
        public string? MaChucNang { get; set; }
        public string? TenQuyen { get; set; }

        public virtual Tblchucnang? MaChucNangNavigation { get; set; }

        public virtual ICollection<Tblphongban> MaPhongBans { get; set; }
    }
}
