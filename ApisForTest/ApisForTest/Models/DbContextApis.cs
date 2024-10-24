using Microsoft.EntityFrameworkCore;

namespace ApisForTest.Models
{
    public class DbContextApis:DbContext
    {
        public DbContextApis(DbContextOptions<DbContextApis> options):base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
