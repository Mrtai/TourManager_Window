using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    class manHinhDAL
    {
        private DB_TOUREntities context = new DB_TOUREntities();
        public int Add(MAN_HINH pT)
        {
            int result = 0;
            context.MAN_HINH.Add(pT);
            result = context.SaveChanges();
            return result;
        }
        public int Update(MAN_HINH pT)
        {
            int result = 0;
            MAN_HINH k = context.MAN_HINH.FirstOrDefault(m => m.MA_MH == pT.MA_MH);
            if (k != null)
            {
                k.TEN_MAN_HINH = pT.TEN_MAN_HINH;
                k.TAG = pT.TAG;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMaT)
        {
            int result = 0;
            MAN_HINH k = context.MAN_HINH.FirstOrDefault(m => m.MA_MH == pMaT);
            context.MAN_HINH.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<MAN_HINH> GetList()
        {
            List<MAN_HINH> list = new List<MAN_HINH>();
            list = context.MAN_HINH.ToList();
            return list;
        }

        public MAN_HINH GetDVByMa(int pMaT)
        {
            MAN_HINH result = new MAN_HINH();
            result = context.MAN_HINH.FirstOrDefault(m => m.MA_MH == pMaT);
            return result;
        }
    }
}
