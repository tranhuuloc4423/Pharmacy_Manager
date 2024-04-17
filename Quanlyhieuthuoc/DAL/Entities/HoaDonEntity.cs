using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class HoaDonEntity
    {
        public int MaHoaDon { get; set; }
        public string TenTaiKhoan { get; set; }
        public double TongTien { get; set; }
        public int MaKhachHang { get; set; }
        public int GiamGia { get; set; }

    }
}
