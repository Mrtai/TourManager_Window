﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_TOUR
{
    public class nhomDAL
    {
        private DB_TOUREntities1 context;
        public nhomDAL()
        {
            string c = Config.GetConnectionString();
            context = new DB_TOUREntities1(c);
        }
        public int Add(NHOM pT)
        {
            int result = 0;
            context.NHOMs.Add(pT);
            result = context.SaveChanges();
            return result;
        }
        public int Update(NHOM pT)
        {
            int result = 0;
            NHOM k = context.NHOMs.FirstOrDefault(m => m.MA_NHOM == pT.MA_NHOM);
            if (k != null)
            {
                k.TEN_NHOM = pT.TEN_NHOM;
                k.GHI_CHU = pT.GHI_CHU;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMaT)
        {
            int result = 0;
            NHOM k = context.NHOMs.FirstOrDefault(m => m.MA_NHOM == pMaT);
            context.NHOMs.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<NHOM> GetList()
        {
            List<NHOM> list = new List<NHOM>();
            list = context.NHOMs.ToList();
            return list;
        }

        public NHOM GetDVByMa(int pMaT)
        {
            NHOM result = new NHOM();
            result = context.NHOMs.FirstOrDefault(m => m.MA_NHOM == pMaT);
            return result;
        }
    }
}
