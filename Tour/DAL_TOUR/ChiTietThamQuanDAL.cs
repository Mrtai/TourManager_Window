using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_TOUR
{
    class ChiTietThamQuanDAL
    {
        private DB_TOUREntities context;
        public ChiTietThamQuanDAL()
        {
            string c = Config.GetConnectionString();
            context = new DB_TOUREntities(c);

        }
        public int Add(CHI_TIET_THAM_QUAN pCT)
        {
            int result = 0;
            context.CHI_TIET_THAM_QUAN.Add(pCT);
            result = context.SaveChanges();
            return result;
        }
        public int Update(CHI_TIET_THAM_QUAN pCT)
        {
            int result = 0;
            CHI_TIET_THAM_QUAN k = context.CHI_TIET_THAM_QUAN.FirstOrDefault(m => m.MA_DIA_DIEM == pCT.MA_DIA_DIEM && m.MA_TOUR == pCT.MA_TOUR);
            if (k != null)
            {
                k.GHI_CHU = pCT.GHI_CHU;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMaTour, int pMaDD)
        {
            int result = 0;
            CHI_TIET_THAM_QUAN k = context.CHI_TIET_THAM_QUAN.FirstOrDefault(m => m.MA_DIA_DIEM == pMaTour && m.MA_TOUR == pMaDD);
            context.CHI_TIET_THAM_QUAN.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<CHI_TIET_THAM_QUAN> GetList()
        {
            List<CHI_TIET_THAM_QUAN> list = new List<CHI_TIET_THAM_QUAN>();
            list = context.CHI_TIET_THAM_QUAN.ToList();
            return list;
        }

        public CHI_TIET_THAM_QUAN GetDVByMa(int pMaTour, int pMaDD)
        {
            CHI_TIET_THAM_QUAN result = new CHI_TIET_THAM_QUAN();
            result = context.CHI_TIET_THAM_QUAN.FirstOrDefault(m => m.MA_DIA_DIEM == pMaTour && m.MA_TOUR == pMaDD);
            return result;
        }
    }
}
