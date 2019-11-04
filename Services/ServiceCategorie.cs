using Data.Infrastructure;
using Domain;
using Domain.Entities;
using MyFinance.Data.Infrastructure;
using Service.Pattern;

namespace Services
{
    public class ServiceCategorie : Service<Categorie>, IServiceCategorie
    {

        private static DatabaseFactory dbf = new DatabaseFactory();

        private static IUnitOfWork uow = new UnitOfWork(dbf);

        public ServiceCategorie() : base(uow)
        {


        }

        /*   MyFinanceContext ctx;
           private static DatabaseFactory dbf = new DatabaseFactory();
           // private IRepositoryBase<Category> repo = new RepositoryBase<Category>(dbf);
           private  static IUnitOfWork uow = new UnitOfWork(dbf);

           public ServiceCategory():base(uow)
           {


           }

           public void AddCategory(Category c)
           {
               //ctx.Categories.Add(c);
               //ctx.Set<Category>().Add(c);
               // repo.add(c);
               //uow.getRepository<Category>().Add(c);


           }

           public void RemoveCategory(Category c)
           {
               //ctx.Categories.Remove(c);
               //ctx.Set<Category>().Remove(c);
               //repo.Delete(c);
               uow.getRepository<Category>().Delete(c);
           }*/
    }
}
