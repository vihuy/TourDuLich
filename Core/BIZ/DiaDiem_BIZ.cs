using Core.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BIZ
{
    public class DiaDiem_BIZ
    {
        DiaDiem_DAL diadiem_dal = new DiaDiem_DAL();
        public IEnumerable GetList()
        {
            return diadiem_dal.getList();
        }
    }
}
