using Microsoft.EntityFrameworkCore;

namespace SonExistence.Repositories
{
    public class DbRepository : DbContext
    {

        public DbRepository(DbContextOptions<DbRepository> configure) : base(configure)
        {
        }
    }
}