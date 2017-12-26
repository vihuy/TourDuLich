﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class QuanLi_Doan
    {
        TourDuLichEntities db = new TourDuLichEntities();
        public List<Doan> layDSDoan()
        {
            return db.Doans.ToList();
        }

        public void ThemDoan(Doan doan)
        {
            try
            {
                db.Doans.Add(doan);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}