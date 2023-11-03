using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06_1
{
    class Khoa
    {
        public String MaKhoa { get; set; }
        public String TenKhoa { get; set; }
        public String GhiChu { get; set; }
        public Khoa()
        {

        }
        public Khoa(string makhoa, string tenkhoa, string ghichu)
        {
            this.MaKhoa = makhoa;
            this.TenKhoa = tenkhoa;
            this.GhiChu = ghichu;
        }
    }
}
