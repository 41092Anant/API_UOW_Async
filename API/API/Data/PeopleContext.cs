using API.Model;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options) : base(options) { }

        public DbSet<Person> Person { get;set; }
    }
}
