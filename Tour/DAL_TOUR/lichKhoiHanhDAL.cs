using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_TOUR
{
    public class lichKhoiHanhDAL
    {
        private DB_TOUREntities1 context ;
        public lichKhoiHanhDAL()
        {
            string c = Config.GetConnectionString();
            context = new DB_TOUREntities1(c);
        }
        public int Add(LICH_KHOI_HANH pLKH)
        {
            int result = 0;
            context.LICH_KHOI_HANH.Add(pLKH);
            result = context.SaveChanges();
            return result;
        }
        public int Update(LICH_KHOI_HANH pLKH)
        {
            int result = 0;
            LICH_KHOI_HANH k = context.LICH_KHOI_HANH.FirstOrDefault(m => m.MA_LICH == pLKH.MA_LICH);
            if (k != null)
            {
                k.TEN_LICH = pLKH.TEN_LICH;
                k.MA_TOUR = pLKH.MA_TOUR;
                k.NGAY_KHOI_HANH = pLKH.NGAY_KHOI_HANH;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMaLKH)
        {
            int result = 0;
            LICH_KHOI_HANH k = context.LICH_KHOI_HANH.FirstOrDefault(m => m.MA_LICH == pMaLKH);
            context.LICH_KHOI_HANH.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<LICH_KHOI_HANH> GetList()
        {
            List<LICH_KHOI_HANH> list = new List<LICH_KHOI_HANH>();
            list = context.LICH_KHOI_HANH.ToList();
            return list;
        }

        public LICH_KHOI_HANH GetDVByMa(int pMaLKH)
        {
            LICH_KHOI_HANH result = new LICH_KHOI_HANH();
            result = context.LICH_KHOI_HANH.FirstOrDefault(m => m.MA_LICH == pMaLKH);
            return result;
        }
    }
}
