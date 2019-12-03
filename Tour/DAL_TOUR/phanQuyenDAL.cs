using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_TOUR
{
    public class phanQuyenDAL
    {
        private DB_TOUREntities1 context ;
        public phanQuyenDAL()
        {
            string c = Config.GetConnectionString();
            context = new DB_TOUREntities1(c);
        }
        public int Add(PHAN_QUYEN pT)
        {
            int result = 0;
            context.PHAN_QUYEN.Add(pT);
            result = context.SaveChanges();
            return result;
        }
        public int Update(PHAN_QUYEN pT)
        {
            int result = 0;
            PHAN_QUYEN k = context.PHAN_QUYEN.FirstOrDefault(m => m.MA_MH == pT.MA_MH && m.MA_NHOM == pT.MA_NHOM);
            if (k != null)
            {
                k.CO_QUYEN = pT.CO_QUYEN;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMaNhom,int pMaMH)
        {
            int result = 0;
            PHAN_QUYEN k = context.PHAN_QUYEN.FirstOrDefault(m => m.MA_NHOM == pMaNhom && m.MA_MH == pMaMH);
            context.PHAN_QUYEN.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<PHAN_QUYEN> GetList()
        {
            List<PHAN_QUYEN> list = new List<PHAN_QUYEN>();
            list = context.PHAN_QUYEN.ToList();
            return list;
        }
        public List<PHAN_QUYEN> GetListBuNhom(int manhom)
        {
            List<PHAN_QUYEN> pq = context.PHAN_QUYEN.Where(m => m.MA_NHOM == manhom).ToList();
            return pq;
        }
        

        public PHAN_QUYEN GetDVByMa(int pMaNhom, int pMaMH)
        {
            PHAN_QUYEN result = new PHAN_QUYEN();
            result = context.PHAN_QUYEN.FirstOrDefault(m => m.MA_NHOM == pMaNhom && m.MA_MH == pMaMH);
            return result;
        }
    }
}
