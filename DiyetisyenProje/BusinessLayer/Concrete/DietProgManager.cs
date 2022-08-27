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
    public class DietProgManager:IDietProgService
    {
        IDietProgDal _dietProgDal;

        public DietProgManager(IDietProgDal dietProgDal)
        {
            _dietProgDal = dietProgDal;
        }

        public List<DietProgram> GetList()
        {
           return _dietProgDal.GetListAll();
        }
        public List<DietProgram> GetListId(int id)
        {
            return _dietProgDal.GetListAll(x=>x.DietID==id);
        }

        public void TAdd(DietProgram t)
        {
            _dietProgDal.Insert(t);
        }

        public void TDelete(DietProgram t)
        {
           _dietProgDal.Delete(t);
        }

        public DietProgram TGetById(int id)
        {
           return _dietProgDal.GetById(id);
        }

        public void TUpdate(DietProgram t)
        {
          _dietProgDal.Update(t);
        }
    }
}
