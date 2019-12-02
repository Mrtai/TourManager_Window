using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_TOUR
{
    class nhanVienNhomDAL
    {
        private DB_TOUREntities context;
        public nhanVienNhomDAL()
        {
            string c = Config.GetConnectionString();
            context = new DB_TOUREntities(c);
        }
        public int Add(NHAN_VIEN_NHOM pT)
        {
            int result = 0;
            context.NHAN_VIEN_NHOM.Add(pT);
            result = context.SaveChanges();
            return result;
        }
        public int Update(NHAN_VIEN_NHOM pT)
        {
            int result = 0;
            NHAN_VIEN_NHOM k = context.NHAN_VIEN_NHOM.FirstOrDefault(m => m.MA_NV == pT.MA_NV && m.MA_NHOM == pT.MA_NHOM);
            if (k != null)
            {
                k.GHI_CHU = pT.GHI_CHU;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMaNhom,int pMaNV)
        {
            int result = 0;
            NHAN_VIEN_NHOM k = context.NHAN_VIEN_NHOM.FirstOrDefault(m => m.MA_NHOM == pMaNhom && m.MA_NV == pMaNV);
            context.NHAN_VIEN_NHOM.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<NHAN_VIEN_NHOM> GetList()
        {
            List<NHAN_VIEN_NHOM> list = new List<NHAN_VIEN_NHOM>();
            list = context.NHAN_VIEN_NHOM.ToList();
            return list;
        }

        public NHAN_VIEN_NHOM GetDVByMa(int pMaNhom, int pMaNV)
        {
            NHAN_VIEN_NHOM result = new NHAN_VIEN_NHOM();
            result = context.NHAN_VIEN_NHOM.FirstOrDefault(m => m.MA_NHOM == pMaNhom && m.MA_NV == pMaNV);
            return result;
        }
    }
}
