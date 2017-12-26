using Core.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BIZ
{
    public class Tour_BIZ
    {
       Tour_DAL tour_dal = new Tour_DAL();
        public IEnumerable GetList()
        {
            return tour_dal.getList();
        }
    }
}
