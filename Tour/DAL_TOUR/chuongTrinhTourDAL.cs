using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_TOUR
{
    public class chuongTrinhTourDAL
    {
        private DB_TOUREntities context;
        public chuongTrinhTourDAL()
        {
            string c = Config.GetConnectionString();
            context = new DB_TOUREntities(c);
        }
        public int Add(CHUONG_TRINH_TOUR pCTT)
        {
            int result = 0;
            context.CHUONG_TRINH_TOUR.Add(pCTT);
            result = context.SaveChanges();
            return result;
        }
        public int Update(CHUONG_TRINH_TOUR pCTT)
        {
            int result = 0;
            CHUONG_TRINH_TOUR k = context.CHUONG_TRINH_TOUR.FirstOrDefault(m => m.MA_CHUONG_TRINH == pCTT.MA_CHUONG_TRINH);
            if (k != null)
            {
                k.MA_KHACH_SAN = pCTT.MA_KHACH_SAN;
                k.MA_TOUR = pCTT.MA_TOUR;
                k.TEN_CHUONG_TRINH = pCTT.TEN_CHUONG_TRINH;
                k.NGAY = pCTT.NGAY;
                k.CHI_TIET = pCTT.CHI_TIET;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMaCCT)
        {
            int result = 0;
            CHUONG_TRINH_TOUR k = context.CHUONG_TRINH_TOUR.FirstOrDefault(m => m.MA_CHUONG_TRINH == pMaCCT);
            context.CHUONG_TRINH_TOUR.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<CHUONG_TRINH_TOUR> GetList()
        {
            List<CHUONG_TRINH_TOUR> list = new List<CHUONG_TRINH_TOUR>();
            list = context.CHUONG_TRINH_TOUR.ToList();
            return list;
        }

        public CHUONG_TRINH_TOUR GetDVByMa(int pMaCCT)
        {
            CHUONG_TRINH_TOUR result = new CHUONG_TRINH_TOUR();
            result = context.CHUONG_TRINH_TOUR.FirstOrDefault(m => m.MA_CHUONG_TRINH == pMaCCT);
            return result;
        }
    }
}
