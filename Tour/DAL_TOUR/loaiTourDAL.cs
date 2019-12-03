using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL_TOUR
{
    public class loaiTourDAL
    {
        private DB_TOUREntities1 context;
        public loaiTourDAL()
        {
            string c = Config.GetConnectionString();
            context = new DB_TOUREntities1(c);
        }
        public int Add(LOAI_TOUR pT)
        {
            int result = 0;
            context.LOAI_TOUR.Add(pT);
            result = context.SaveChanges();
            return result;
        }
        public int Update(LOAI_TOUR pT)
        {
            int result = 0;
            LOAI_TOUR k = context.LOAI_TOUR.FirstOrDefault(m => m.MA_LOAI == pT.MA_LOAI);
            if (k != null)
            {
                k.TEN_LOAI = pT.TEN_LOAI;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMaT)
        {
            int result = 0;
            LOAI_TOUR k = context.LOAI_TOUR.FirstOrDefault(m => m.MA_LOAI == pMaT);
            context.LOAI_TOUR.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<LOAI_TOUR> GetList()
        {
            List<LOAI_TOUR> list = new List<LOAI_TOUR>();
            list = context.LOAI_TOUR.ToList();
            return list;
        }

        public LOAI_TOUR GetDVByMa(int pMaT)
        {
            LOAI_TOUR result = new LOAI_TOUR();
            result = context.LOAI_TOUR.FirstOrDefault(m => m.MA_LOAI == pMaT);
            return result;
        }
    }
}
