using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_TOUR
{
    class DanhSachDichVuDAL
    {
        private DB_TOUREntities context = new DB_TOUREntities();
        public int Add(DANH_SACH_DICH_VU pDS)
        {
            int result = 0;
            context.DANH_SACH_DICH_VU.Add(pDS);
            result = context.SaveChanges();
            return result;
        }
        public int Update(DANH_SACH_DICH_VU pDS)
        {
            int result = 0;
            DANH_SACH_DICH_VU k = context.DANH_SACH_DICH_VU.FirstOrDefault(m => m.MA_DICH_VU == pDS.MA_DICH_VU && m.MA_TOUR == pDS.MA_TOUR);
            if (k != null)
            {
                k.SO_LUONG = pDS.SO_LUONG;
                k.THANH_TIEN = pDS.THANH_TIEN;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMaDV, int pMaTour)
        {
            int result = 0;
            DANH_SACH_DICH_VU k = context.DANH_SACH_DICH_VU.FirstOrDefault(m => m.MA_DICH_VU == pMaDV && m.MA_TOUR == pMaTour);
            context.DANH_SACH_DICH_VU.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<DANH_SACH_DICH_VU> GetList()
        {
            List<DANH_SACH_DICH_VU> list = new List<DANH_SACH_DICH_VU>();
            list = context.DANH_SACH_DICH_VU.ToList();
            return list;
        }

        public DANH_SACH_DICH_VU GetDVByMa(int pMaDV, int pMaTour)
        {
            DANH_SACH_DICH_VU result = new DANH_SACH_DICH_VU();
            result = context.DANH_SACH_DICH_VU.FirstOrDefault(m => m.MA_DICH_VU == pMaDV && m.MA_TOUR == pMaTour);
            return result;
        }
    }
}
