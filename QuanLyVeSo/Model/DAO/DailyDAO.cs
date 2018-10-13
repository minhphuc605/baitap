using Model.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class DailyDAO
    {
        private Quanlyveso dbContext = null;

        public DailyDAO()
        {
            dbContext = new Quanlyveso();
        }

        public List<DAILY> ListAll ()
        {
            var result = dbContext.DAILies.ToList();
            return result;
        }

        public int Insert (DAILY entity)
        {
            dbContext.DAILies.Add(entity);
            dbContext.SaveChanges();
            return entity.MADAILY;
        }
        public bool update (DAILY entity)
        {
            var cat = dbContext.DAILies.Find(entity.MADAILY);
            cat.MADAILY = entity.MADAILY;
            cat.TENDAILY = entity.TENDAILY;
            dbContext.SaveChanges();
            return true;
        }
        
    }
}
