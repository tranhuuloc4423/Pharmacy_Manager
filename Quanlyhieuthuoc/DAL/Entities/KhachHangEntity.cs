﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class KhachHangEntity
    {
        
        public int MaKhachHang{ get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public int KhachHangThanThiet { get; set; }
        public double MuaTichLuy { get; set; }

    }
}