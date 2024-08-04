using EasyCashIdentityProject.DataAccessLayer.Migrations;
using EasyCashIdentityProject.EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerAccount = EasyCashIdentityProject.EntityLayer.Concreate.CustomerAccount;

namespace EasyCashIdentityProject.DataAccessLayer.Abstract
{
    public interface ICustomerAccountDal : IGenericDal<CustomerAccount>
    {
    }
}
