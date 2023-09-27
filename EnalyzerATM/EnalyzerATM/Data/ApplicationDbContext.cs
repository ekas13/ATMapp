namespace ATMapp.Data
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Transactions;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=..\\ATM.db;");
        }


    }

}
