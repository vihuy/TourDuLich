using Core.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BIZ
{
    public class Quanli_TinhThanh_BIZ
    {
        QuanLi_TinhThanh_Dal dal_tinhthanh = new QuanLi_TinhThanh_Dal();
        public IEnumerable layTinhThanh()
        {
            return dal_tinhthanh.layTinhThanh();
        }
    }
    
}
