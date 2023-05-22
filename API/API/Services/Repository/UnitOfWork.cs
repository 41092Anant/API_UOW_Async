using API.Data;
using API.Model;
using API.Services.Interface;
using System.Net;

namespace API.Services.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private PeopleContext context;

        public UnitOfWork(PeopleContext context)
        {
            this.context = context;
            Person = new PersonRepository(this.context);
        }

        public IPersonRepository Person { get; private set; }

        public void Dispose()
        {
            context.Dispose();
        }
        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
