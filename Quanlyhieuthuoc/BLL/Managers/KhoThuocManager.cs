﻿using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers
{
    public class KhoThuocManager
    {
        private KhoThuocRepo process;

        public KhoThuocManager()
        {
            process = new KhoThuocRepo();
        }

        public DataTable HienThiDanhSach(ref string error)
        {
            return process.HienThiDanhSach(ref error);
        }
    }
}
