using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P.S.S.Models
{
    public class ApplicationDBContext: IdentityDbContext<MyUsersIdentity, IdentityRole, string>
    {
        public DbSet<ReservationModel> Reservations { get; set;}
        public DbSet<MyUsersIdentity> MyUsers { get; set; }
        public DbSet<ReservationModel> Reservations_2 { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> dbContext): base(dbContext)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            AddAdminUser.SeedData(builder);
        }
    }
}
