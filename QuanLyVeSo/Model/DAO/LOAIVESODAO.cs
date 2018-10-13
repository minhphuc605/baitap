using Model.EntityFramework;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class LOAIVESODAO
    {
        private Quanlyveso dbContext = null;
        public LOAIVESODAO()
        {
            dbContext = new Quanlyveso();
        }

        public List<LOAIVESO> ListAll()
        {
            var result = dbContext.LOAIVESOes.ToList();
            return result;
        }
        public IEnumerable<LOAIVESO> GetListPaging(int page, int PageSize)
        {
            return dbContext.LOAIVESOes.ToPagedList(page,PageSize);
        }
        public int insert(LOAIVESO entity)
        {
            dbContext.LOAIVESOes.Add(entity);
            dbContext.SaveChanges();
            return entity.MALOAI;
        }
        public bool update (LOAIVESO entity)
        {
            var cat = dbContext.LOAIVESOes.Find(entity);
            cat.MALOAI = entity.MALOAI;
            cat.TENLOAI = entity.TENLOAI;
            dbContext.SaveChanges();
            return true;
        }

    }
}
