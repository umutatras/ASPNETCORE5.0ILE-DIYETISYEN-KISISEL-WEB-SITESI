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
    public class ContactStaticManager : IContactStaticService
    {
        IContactStaticDal _contactStaticDal;

        public ContactStaticManager(IContactStaticDal contactStaticDal)
        {
            _contactStaticDal = contactStaticDal;
        }

        public List<ContactStatic> GetList()
        {
            return _contactStaticDal.GetListAll();
        }

        public void TAdd(ContactStatic t)
        {
            _contactStaticDal.Insert(t);
        }

        public void TDelete(ContactStatic t)
        {
           _contactStaticDal.Delete(t);
        }

        public ContactStatic TGetById(int id)
        {
           return _contactStaticDal.GetById(id);
        }

        public void TUpdate(ContactStatic t)
        {
            _contactStaticDal.Update(t);
        }
    }
}
