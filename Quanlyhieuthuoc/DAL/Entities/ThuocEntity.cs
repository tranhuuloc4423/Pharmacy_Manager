using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ThuocEntity
    {
        public int MaLoaiThuoc { get; set; }
        public int MaNhaCungCap { get; set; }
        public string TenThuoc { get; set; }
        public string DonViTinh { get; set; }
        public int GiaBan { get; set; }
    }
}
