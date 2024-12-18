using Microsoft.EntityFrameworkCore;

namespace WebApi8_Video.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }
    }
}
