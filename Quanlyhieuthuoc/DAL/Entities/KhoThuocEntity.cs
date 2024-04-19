using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class KhoThuocEntity
    {
        public int Thang { get; set; }
        public int Nam { get; set; }
        public int MaThuoc { get; set; }
        public int DauKy { get; set; }
        public int NhapTrongKy { get; set; }
        public int XuatTrongThang { get; set; }
        public int TonKho { get; set; }
    }
}
