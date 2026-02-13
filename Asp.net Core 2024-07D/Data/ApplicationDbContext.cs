using Asp.net_Core_2024_07D.Models;
using Microsoft.EntityFrameworkCore;


namespace Asp.net_Core_2024_07D.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets (Tables)
        public DbSet<Voucher> Voucher { get; set; }
    }
}