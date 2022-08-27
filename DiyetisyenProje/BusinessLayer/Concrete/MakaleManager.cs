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
    public class MakaleManager : IMakaleService
    {
        IMakaleDal _makaleDal;

        public MakaleManager(IMakaleDal makaleDal)
        {
            _makaleDal = makaleDal;
        }

        public List<Makale> GetList()
        {
          return _makaleDal.GetListAll();

        }
        public List<Makale> GetIdMakale(int id)
        {
            return _makaleDal.GetListAll(x => x.MakaleID == id);
        }

        public void TAdd(Makale t)
        {
            _makaleDal.Insert(t);
        }

        public void TDelete(Makale t)
        {
            _makaleDal.Delete(t);
        }

        public Makale TGetById(int id)
        {
            return _makaleDal.GetById(id);
        }

        public void TUpdate(Makale t)
        {
            _makaleDal.Update(t);
        }
    }
}
