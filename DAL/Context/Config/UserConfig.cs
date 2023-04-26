using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasCheckConstraint("CK_Email", "[Email] LIKE '%@%.%'");
            builder.HasIndex(u => u.Email).IsUnique();
            builder.HasData(
                            new User
                            {
                                Id = 1,
                                Email = "jeremy.bazin@email.com",
                                Password = "Test123=",
                                LastName = "Bazin",
                                FirstName = "Jeremy"
 
                            },
                            new User
                            {
                                Id = 2,
                                Email = "bob.martin@email.com",
                                Password = "5Gh#zBvKw3PxYrE",
                                LastName = "Martin",
                                FirstName = "Bob",


                            },
                            new User
                            {
                                Id = 3,
                                Email = "charlie.nguyen@email.com",
                                Password = "fT7#eRm2QxLz9Dy$",
                                LastName = "Nguyen",
                                FirstName = "Charlie",


                            },
                            new User
                            {
                                Id = 4,
                                Email = "david.lee@email.com",
                                Password = "V6b$UwPcNz @hM8xK",
                                LastName = "Lee",
                                FirstName = "David",


                            },
                            new User
                            {
                                Id = 5,
                                Email = "emma.garcia@email.com",
                                Password = "aH5%kXjL9$qBm2W",
                                LastName = "Garcia",
                                FirstName = "Emma",


                            },
                            new User
                            {
                                Id = 6,
                                Email = "frank.chen@email.com",
                                Password = "qJ9@fM8cWu5$xLrE",
                                LastName = "Chen",
                                FirstName = "Frank",


                            },
                            new User
                            {
                                Id = 7,
                                Email = "grace.wong@email.com",
                                Password = "7Km&zRb#vGy2hNj",
                                LastName = "Wong",
                                FirstName = "Grace",

                            },
                            new User
                            {
                                Id = 8,
                                Email = "henry.zhang@email.com",
                                Password = "T4c#nSv@wGj2RkF",
                                LastName = "Zhang",
                                FirstName = "Henry",

                            },
                            new User
                            {
                                Id = 9,
                                Email = "isabella.lopez@email.com",
                                Password = "H8f$kL3q#sVp9Xy",
                                LastName = "Lopez",
                                FirstName = "Isabella",
                            },
                            new User
                            {
                                Id = 10,
                                Email = "jack.kim@email.com",
                                Password = "3ZgY*6tLx#pVfDhN",
                                LastName = "Kim",
                                FirstName = "Jack",

                            }
                        );
        }
    }
}
