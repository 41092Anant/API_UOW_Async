using API.Data;
using API.Model;
using API.Services.Interface;

namespace API.Services.Repository
{
    class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(PeopleContext context) : base(context) { }
    }
}
