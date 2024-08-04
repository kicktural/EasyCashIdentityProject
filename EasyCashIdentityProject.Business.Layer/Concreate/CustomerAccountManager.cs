using Azure.Core;
using EasyCashIdentityProject.Business.Layer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.Business.Layer.Concreate
{
    public class CustomerAccountManager : ICustomerAccountService
    {

        private readonly ICustomerAccountDal _customerAccountDal;

        public CustomerAccountManager(ICustomerAccountDal customerAccountDal)
        {
            _customerAccountDal = customerAccountDal;
        }

        public void TDelete(EntityLayer.Concreate.CustomerAccount t)
        {
            _customerAccountDal.Delete(t);
        }

        public EntityLayer.Concreate.CustomerAccount TGetById(int id)
        {
            return _customerAccountDal.GetById(id);
        }

        public List<EntityLayer.Concreate.CustomerAccount> TGetList()
        {
            return _customerAccountDal.GetList();
        }

        public void TInsert(EntityLayer.Concreate.CustomerAccount t)
        {
            _customerAccountDal.Insert(t);
        }

        public void TUpdate(EntityLayer.Concreate.CustomerAccount t)
        {
            _customerAccountDal.Update(t);
        }
    }
}
