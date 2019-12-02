using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_TOUR
{
    public class diaDiemDuLichDAL
    {
        private DB_TOUREntities context;
        public diaDiemDuLichDAL()
        {
            string c = Config.GetConnectionString();
            context = new DB_TOUREntities(c);
        }
        public int Add(DIA_DIEM_DU_LICH pDD)
        {
            int result = 0;
            context.DIA_DIEM_DU_LICH.Add(pDD);
            result = context.SaveChanges();
            return result;
        }
        public int Update(DIA_DIEM_DU_LICH pDD)
        {
            int result = 0;
            DIA_DIEM_DU_LICH k = context.DIA_DIEM_DU_LICH.FirstOrDefault(m => m.MA_DIA_DIEM == pDD.MA_DIA_DIEM);
            if (k != null)
            {
                k.TEN_DIA_DIEM = pDD.TEN_DIA_DIEM;
                k.MA_TINH = pDD.MA_TINH;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMaDD)
        {
            int result = 0;
            DIA_DIEM_DU_LICH k = context.DIA_DIEM_DU_LICH.FirstOrDefault(m => m.MA_DIA_DIEM == pMaDD);
            context.DIA_DIEM_DU_LICH.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<DIA_DIEM_DU_LICH> GetListDD()
        {
            List<DIA_DIEM_DU_LICH> list = new List<DIA_DIEM_DU_LICH>();
            list = context.DIA_DIEM_DU_LICH.ToList();
            return list;
        }

        public DIA_DIEM_DU_LICH GetDVByMa(int pMaDD)
        {
            DIA_DIEM_DU_LICH result = new DIA_DIEM_DU_LICH();
            result = context.DIA_DIEM_DU_LICH.FirstOrDefault(m => m.MA_DIA_DIEM == pMaDD);
            return result;
        }
    }
}
