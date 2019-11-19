using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    public class hoaDonDAL
    {
        private DB_TOUREntities context = new DB_TOUREntities();
        public int Add(HOA_DON pHD)
        {
            int result = 0;
            context.HOA_DON.Add(pHD);
            result = context.SaveChanges();
            return result;
        }
        public int Update(HOA_DON pHD)
        {
            int result = 0;
            HOA_DON k = context.HOA_DON.FirstOrDefault(m => m.MA_HD == pHD.MA_HD);
            if (k != null)
            {
                k.MA_LOAI_TT = pHD.MA_LOAI_TT;
                k.TONG_TIEN = k.TONG_TIEN;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMaHD)
        {
            int result = 0;
            HOA_DON k = context.HOA_DON.FirstOrDefault(m => m.MA_HD == pMaHD);
            context.HOA_DON.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<HOA_DON> GetList()
        {
            List<HOA_DON> list = new List<HOA_DON>();
            list = context.HOA_DON.ToList();
            return list;
        }

        public HOA_DON GetDVByMa(int pMaHD)
        {
            HOA_DON result = new HOA_DON();
            result = context.HOA_DON.FirstOrDefault(m => m.MA_HD == pMaHD);
            return result;
        }
    }
}
