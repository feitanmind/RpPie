using Microsoft.EntityFrameworkCore;
using RpPie.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpPie.Infrastucture.Persistance
{
    public class RpPieDbContext : DbContext
    {
        public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=sql.bsite.net\\MSSQL2016;Database=rppie_db;User id=rppie_db;Password=6.QkD,Q@@dST]KN;Encrypt=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrganizationUnit>()
                .OwnsOne(c => c.ContactDetails);
        }
    }
}
