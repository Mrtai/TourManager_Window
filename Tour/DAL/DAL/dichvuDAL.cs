using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    class dichvuDAL
    {
        private DB_TOUREntities context = new DB_TOUREntities();
        public int AddNewDichVu(DICH_VU pDV)
        {
            int result = 0;
            context.DICH_VU.Add(pDV);
            result = context.SaveChanges();
            return result;
        }
        public int UpdateDV(DICH_VU pDV)
        {
            int result = 0;
            DICH_VU k = context.DICH_VU.FirstOrDefault(m => m.MA_DICH_VU == pDV.MA_DICH_VU);
            if (k != null)
            {
                k.TEN_DICH_VU = pDV.TEN_DICH_VU;
                k.GIA = pDV.GIA;
            }   
            result = context.SaveChanges();
            return result;
        }
        
        public int DeleteDV(int pMaDV)
        {
            int result = 0;
            DICH_VU k = context.DICH_VU.FirstOrDefault(m => m.MA_DICH_VU == pMaDV);
            context.DICH_VU.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<DICH_VU> GetListDV()
        {
            List<DICH_VU> list = new List<DICH_VU>();
            list = context.DICH_VU.ToList();
            return list;
        }

        public DICH_VU GetDVByMa(int pMaDV)
        {
            DICH_VU result = new DICH_VU();
            result = context.DICH_VU.FirstOrDefault(m => m.MA_DICH_VU == pMaDV);
            return result;
        }
    }
}
