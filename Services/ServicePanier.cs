using Data.Infrastructure;
using Domain.Entities;
using MyFinance.Data.Infrastructure;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServicePanier : Service<Panier>, IServicePanier
    {
        private static DatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork uow = new UnitOfWork(dbf);
        public ServicePanier() : base(uow)
        {

        }
    }
}
