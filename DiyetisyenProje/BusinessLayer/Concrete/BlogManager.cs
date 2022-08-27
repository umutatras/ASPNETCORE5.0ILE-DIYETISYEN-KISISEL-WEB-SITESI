using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogtDal;

        public BlogManager(IBlogDal blogtDal)
        {
            _blogtDal = blogtDal;
        }

        public List<Blog> GetList()
        {
            return _blogtDal.GetListAll();
        }
        public List<Blog> GetBlogById(int id)
        {
            return _blogtDal.GetListAll(x => x.BlogID == id);
        }
        public void TAdd(Blog t)
        {
          _blogtDal.Insert(t);  
        }

        public void TDelete(Blog t)
        {
           _blogtDal.Delete(t);
        }

        public Blog TGetById(int id)
        {
            return _blogtDal.GetById(id);
        }

        public void TUpdate(Blog t)
        {
            _blogtDal.Update(t);
        }
    }
}
