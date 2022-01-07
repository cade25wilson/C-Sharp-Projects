using bankProgram.Models;
using Microsoft.EntityFrameworkCore;

namespace BankProgram1.Models
{
    public class BankDbContext : DbContext
    {
        public BankDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transfer> Transfers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
