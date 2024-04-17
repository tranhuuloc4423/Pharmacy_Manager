using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ChiTietPhieuNhapEntity
    {
        public int MaChiTietPhieuNhap { get; set; }
        public int MaPhieuNhap { get; set; }
        public int MaThuoc { get; set; }
        public int SoLuong { get; set; }
    }
}
