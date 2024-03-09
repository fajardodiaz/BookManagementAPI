using Microsoft.EntityFrameworkCore;

namespace BookManagementAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
