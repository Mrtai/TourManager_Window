using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    public class khachHangDAL
    {
        private DB_TOUREntities context = new DB_TOUREntities();
        public int Add(KHACH_HANG pKH)
        {
            int result = 0;
            context.KHACH_HANG.Add(pKH);
            result = context.SaveChanges();
            return result;
        }
        public int Update(KHACH_HANG pKH)
        {
            int result = 0;
            KHACH_HANG k = context.KHACH_HANG.FirstOrDefault(m => m.MA_KHACH_HANG == pKH.MA_KHACH_HANG);
            if (k != null)
            {
                k.TEN = pKH.TEN;
                k.DIA_CHI = pKH.DIA_CHI;
                k.DIEN_THOAI = pKH.DIEN_THOAI;
                k.EMAIL = pKH.EMAIL;
                k.NGAY_SINH = pKH.NGAY_SINH;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMaKH)
        {
            int result = 0;
            KHACH_HANG k = context.KHACH_HANG.FirstOrDefault(m => m.MA_KHACH_HANG == pMaKH);
            context.KHACH_HANG.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<KHACH_HANG> GetList()
        {
            List<KHACH_HANG> list = new List<KHACH_HANG>();
            list = context.KHACH_HANG.ToList();
            return list;
        }

        public KHACH_HANG GetDVByMa(int pMaKH)
        {
            KHACH_HANG result = new KHACH_HANG();
            result = context.KHACH_HANG.FirstOrDefault(m => m.MA_KHACH_HANG == pMaKH);
            return result;
        }
    }
}
