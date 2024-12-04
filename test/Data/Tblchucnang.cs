using System;
using System.Collections.Generic;

namespace test.Data
{
    public partial class Tblchucnang
    {
        public Tblchucnang()
        {
            Tblquyens = new HashSet<Tblquyen>();
        }

        public string MaChucNang { get; set; } = null!;
        public string? TenChucNang { get; set; }

        public virtual ICollection<Tblquyen> Tblquyens { get; set; }
    }
}
