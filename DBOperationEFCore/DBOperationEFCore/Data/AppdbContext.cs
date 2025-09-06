using Microsoft.EntityFrameworkCore;

namespace DBOperationEFCore.Data
{
    public class AppdbContext : DbContext
    {
        public AppdbContext(DbContextOptions<AppdbContext> options):base(options)
        { 
        }
    }
}
