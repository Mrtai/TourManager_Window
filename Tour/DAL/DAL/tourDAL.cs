using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    class tourDAL
    {
        private DB_TOUREntities context = new DB_TOUREntities();
        public int Add(TOUR pT)
        {
            int result = 0;
            context.TOURs.Add(pT);
            result = context.SaveChanges();
            return result;
        }
        public int Update(TOUR pT)
        {
            int result = 0;
            TOUR k = context.TOURs.FirstOrDefault(m => m.MA_TOUR == pT.MA_TOUR);
            if (k != null)
            {
                k.TEN_TOUR = pT.TEN_TOUR;
                k.IMAGE = pT.IMAGE;
                k.MA_LOAI = pT.MA_LOAI;
                k.SO_CHO = pT.SO_CHO;
                k.SO_NGAY = pT.SO_NGAY;
                k.DISCOUNT = pT.DISCOUNT;
                k.GIA = pT.GIA;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMaT)
        {
            int result = 0;
            TOUR k = context.TOURs.FirstOrDefault(m => m.MA_TOUR == pMaT);
            context.TOURs.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<TOUR> GetList()
        {
            List<TOUR> list = new List<TOUR>();
            list = context.TOURs.ToList();
            return list;
        }

        public TOUR GetDVByMa(int pMaT)
        {
            TOUR result = new TOUR();
            result = context.TOURs.FirstOrDefault(m => m.MA_TOUR == pMaT);
            return result;
        }
    }
}
