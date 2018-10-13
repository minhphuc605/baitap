using Model.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    class PHATHANHDAO
    {
        private Quanlyveso dbContext = null;

        public PHATHANHDAO()
        {
            dbContext = new Quanlyveso();
        }
        public List<PHATHANH> ListAll()
        {
            var result = dbContext.PHATHANHs.ToList();
            return result;
        }
    }
}
