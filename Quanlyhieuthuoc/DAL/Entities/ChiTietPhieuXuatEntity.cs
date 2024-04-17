using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ChiTietPhieuXuatEntity
    {
        public int MaChiTietPhieuXuat {  get; set; }
        public int MaPhieuXuat { get; set; }
        public int MaThuoc { get; set; }
        public int SoLuong { get; set; }
    }
}
