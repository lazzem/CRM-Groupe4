using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Infrastructure;
using System.Linq.Expressions;
using Service.Pattern;
using Domaine.Entities;
using MyFinance.Data.Infrastructure;

namespace Services
{
    public class ServiceUser : Service<User>, IServiceUser
    {
        private static DatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork uow = new UnitOfWork(dbf);
        public ServiceUser() : base(uow)
        {

        }
    }
}
