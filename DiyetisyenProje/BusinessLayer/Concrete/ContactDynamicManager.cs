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
    public class ContactDynamicManager : IContactDynamicService
    {
        IContactDynamicDal _contactDynamicDal;

        public ContactDynamicManager(IContactDynamicDal contactDynamicDal)
        {
            _contactDynamicDal = contactDynamicDal;
        }

        public List<ContactDynamic> GetList()
        {
           return _contactDynamicDal.GetListAll();
        }

        public void TAdd(ContactDynamic t)
        {
            _contactDynamicDal.Insert(t);
        }

        public void TDelete(ContactDynamic t)
        {
            _contactDynamicDal.Delete(t);
        }

        public ContactDynamic TGetById(int id)
        {
            return _contactDynamicDal.GetById(id);
        }

        public void TUpdate(ContactDynamic t)
        {
            _contactDynamicDal.Update(t);
        }
    }
}
