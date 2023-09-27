namespace EnalyzerATM.Data
{
    using EnalyzerATM.Models;
    using Microsoft.EntityFrameworkCore;
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=..\\ATM.db;");
        }

        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Coins> Coins { get; set; }
        public DbSet<Notes> Notes { get; set; }
        public DbSet<Transactions> Transactions { get; set; }

    }

}
