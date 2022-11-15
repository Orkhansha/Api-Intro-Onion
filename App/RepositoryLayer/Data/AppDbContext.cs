using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
    }
}
