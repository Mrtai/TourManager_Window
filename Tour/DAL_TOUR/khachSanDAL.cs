using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_TOUR
{
    public class khachSanDAL
    {
        private DB_TOUREntities context = new DB_TOUREntities();
        public int AddNewKhachSan(KHACH_SAN pKS)
        {
            int result = 0;
            context.KHACH_SAN.Add(pKS);
            result = context.SaveChanges();
            return result;
        }
        public int UpdateKS(KHACH_SAN pKS)
        {
            int result = 0;
            KHACH_SAN k = context.KHACH_SAN.FirstOrDefault(m => m.MA_KHACH_SAN == pKS.MA_KHACH_SAN);
            if (k != null)
            {
                k.TEN_KHACH_SAN = pKS.TEN_KHACH_SAN;
                k.MA_TINH = pKS.MA_TINH;
            }
            result = context.SaveChanges();
            return result;
        }

        public int DeleteKS(int pMaKS)
        {
            int result = 0;
            KHACH_SAN k = context.KHACH_SAN.FirstOrDefault(m => m.MA_KHACH_SAN == pMaKS);
            context.KHACH_SAN.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<KHACH_SAN> GetListKS()
        {
            List<KHACH_SAN> list = new List<KHACH_SAN>();
            list = context.KHACH_SAN.ToList();
            return list;
        }

        public KHACH_SAN GetDVByMa(int pMaKS)
        {
            KHACH_SAN result = new KHACH_SAN();
            result = context.KHACH_SAN.FirstOrDefault(m => m.MA_KHACH_SAN == pMaKS);
            return result;
        }
    }
}
