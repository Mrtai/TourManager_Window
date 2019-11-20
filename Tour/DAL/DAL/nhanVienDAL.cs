﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    class nhanVienDAL
    {
        private DB_TOUREntities context = new DB_TOUREntities();
        public int Add(NHAN_VIEN pT)
        {
            int result = 0;
            context.NHAN_VIEN.Add(pT);
            result = context.SaveChanges();
            return result;
        }
        public int Update(NHAN_VIEN pT)
        {
            int result = 0;
            NHAN_VIEN k = context.NHAN_VIEN.FirstOrDefault(m => m.MA_NV == pT.MA_NV);
            if (k != null)
            {
                k.TEN_NV = pT.TEN_NV;
                k.USERNAME = pT.USERNAME;
                k.PASSWORD = pT.PASSWORD;
                k.DIA_CHI = pT.DIA_CHI;
                k.EMAIL = pT.EMAIL;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMaT)
        {
            int result = 0;
            NHAN_VIEN k = context.NHAN_VIEN.FirstOrDefault(m => m.MA_NV == pMaT);
            context.NHAN_VIEN.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<NHAN_VIEN> GetList()
        {
            List<NHAN_VIEN> list = new List<NHAN_VIEN>();
            list = context.NHAN_VIEN.ToList();
            return list;
        }

        public NHAN_VIEN GetDVByMa(int pMaT)
        {
            NHAN_VIEN result = new NHAN_VIEN();
            result = context.NHAN_VIEN.FirstOrDefault(m => m.MA_NV == pMaT);
            return result;
        }
    }
}