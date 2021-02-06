using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P.S.S.Models
{
    public static class AddAdminUser
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            const string ADMIN_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
            const string ROLE_ADM_ID = ADMIN_ID;

           // const string USER_ID = "a12be9c5-aa65-4af6-bd97-00bd9344e575";
            //const string ROLE_USR_ID = USER_ID;

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole 
            { 
                Id = ROLE_ADM_ID,
                Name = "Admin"
            });
            /*
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole 
            { 
                Id = ROLE_USR_ID,
                Name = "User"
            });
            */
            var hasher = new PasswordHasher<MyUsersIdentity>();
            modelBuilder.Entity<MyUsersIdentity>().HasData(new MyUsersIdentity
            { 
                Id = ADMIN_ID,
                Name = "Sara",
                Surname = "Konor", 
                TelNumber = "+485756451",
                Email = "sara@gmail.com",
                Gender = "Female",
                PasswordHash = hasher.HashPassword(null, "demo"),
                SecurityStamp = string.Empty
            });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> 
            { 
              RoleId = ROLE_ADM_ID,
              UserId = ADMIN_ID
            });
        }
    }
}
