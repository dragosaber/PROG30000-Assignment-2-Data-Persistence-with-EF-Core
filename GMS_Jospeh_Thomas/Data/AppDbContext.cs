using Microsoft.EntityFrameworkCore;
using GMS_Jospeh_Thomas.Models;

namespace GMS_Jospeh_Thomas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<ItemInfo> ItemInfos { get; set; }

    }
}
