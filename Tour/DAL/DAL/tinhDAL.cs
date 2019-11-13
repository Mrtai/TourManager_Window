using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    class tinhDAL
    {
        private DB_TOUREntities context = new DB_TOUREntities();
        public List<TINH> GetListTinh()
        {
            List<TINH> list = new List<TINH>();
            list = context.TINHs.ToList();
            return list;
        }
    }
}
