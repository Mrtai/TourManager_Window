using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_TOUR
{
    public class tourDatDAL
    {
        private DB_TOUREntities1 context ;
        public tourDatDAL()
        {
            string c = Config.GetConnectionString();
            context = new DB_TOUREntities1(c);
        }
        public int Add(TOUR_DAT pTD)
        {
            int result = 0;
            context.TOUR_DAT.Add(pTD);
            result = context.SaveChanges();
            return result;
        }
        public int Update(TOUR_DAT pTD)
        {
            int result = 0;
            TOUR_DAT k = context.TOUR_DAT.FirstOrDefault(m => m.MA_TOUR_DAT == pTD.MA_TOUR_DAT);
            if (k != null)
            {
                k.DIEM_DON = pTD.DIEM_DON;
                k.MA_KHACH_HANG = pTD.MA_KHACH_HANG;
                k.MA_LICH = pTD.MA_LICH;
                k.NGAY_DAT = pTD.NGAY_DAT;
                k.TRANG_THAI = pTD.TRANG_THAI;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMaTD)
        {
            int result = 0;
            TOUR_DAT k = context.TOUR_DAT.FirstOrDefault(m => m.MA_TOUR_DAT == pMaTD);
            context.TOUR_DAT.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<TOUR_DAT> GetList()
        {
            List<TOUR_DAT> list = new List<TOUR_DAT>();
            list = context.TOUR_DAT.ToList();
            return list;
        }

        public TOUR_DAT GetDVByMa(int pMaTD)
        {
            TOUR_DAT result = new TOUR_DAT();
            result = context.TOUR_DAT.FirstOrDefault(m => m.MA_TOUR_DAT == pMaTD);
            return result;
        }
        public List<TOUR_DAT> GetDVByFilterNgay(System.DateTime from, System.DateTime to)
        {
            
            List<TOUR_DAT> list = new List<TOUR_DAT>();

            list = context.TOUR_DAT.Where(m => m.NGAY_DAT >= from && m.NGAY_DAT <= to).ToList();
            return list;
        }
        public List<TOUR_DAT> GetDVByFilterNgay(int month, int year)
        {
            List<TOUR_DAT> list = new List<TOUR_DAT>();

            list = context.TOUR_DAT.Where(m => m.NGAY_DAT.Value.Month == month && m.NGAY_DAT.Value.Year == year).ToList();
            return list;
        }
    }
}
