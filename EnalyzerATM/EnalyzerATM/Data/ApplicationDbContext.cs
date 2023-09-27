namespace EnalyzerATM.Data
{
    using Effort;
    using EnalyzerATM.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Data.Common;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=..\\ATM.db;");
        }

        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<Coins> Coins { get; set; }
        public virtual DbSet<Notes> Notes { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }

    }

}
