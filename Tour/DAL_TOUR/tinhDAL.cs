using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_TOUR
{
    public class tinhDAL
    {
        private DB_TOUREntities context ;
        public tinhDAL()
        {
            string c = Config.GetConnectionString();
            context = new DB_TOUREntities(c);
        }
        public List<TINH> GetListTinh()
        {
            List<TINH> list = new List<TINH>();
            list = context.TINHs.ToList();
            return list;
        }
    }
}
