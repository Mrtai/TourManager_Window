using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_TOUR
{
    public class loaiThanhToanDAL
    {
        private DB_TOUREntities context = new DB_TOUREntities();
        public int Add(LOAI_THANH_TOAN pTT)
        {
            int result = 0;
            context.LOAI_THANH_TOAN.Add(pTT);
            result = context.SaveChanges();
            return result;
        }
        public int Update(LOAI_THANH_TOAN pTT)
        {
            int result = 0;
            LOAI_THANH_TOAN k = context.LOAI_THANH_TOAN.FirstOrDefault(m => m.MA_LOAI_TT == pTT.MA_LOAI_TT);
            if (k != null)
            {
                k.TEN_LOAI_TT = pTT.TEN_LOAI_TT;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMaTT)
        {
            int result = 0;
            LOAI_THANH_TOAN k = context.LOAI_THANH_TOAN.FirstOrDefault(m => m.MA_LOAI_TT == pMaTT);
            context.LOAI_THANH_TOAN.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<LOAI_THANH_TOAN> GetList()
        {
            List<LOAI_THANH_TOAN> list = new List<LOAI_THANH_TOAN>();
            list = context.LOAI_THANH_TOAN.ToList();
            return list;
        }

        public LOAI_THANH_TOAN GetDVByMa(int pMaTT)
        {
            LOAI_THANH_TOAN result = new LOAI_THANH_TOAN();
            result = context.LOAI_THANH_TOAN.FirstOrDefault(m => m.MA_LOAI_TT == pMaTT);
            return result;
        }
    }
}
