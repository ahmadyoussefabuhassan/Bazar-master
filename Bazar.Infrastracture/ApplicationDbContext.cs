using Bazar.Domain.Entitis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Bazar.Infrastracture.HelpersInfrastracture;

namespace Bazar.Infrastracture
{
    public class ApplicationDbContext : IdentityDbContext<UserLogIn>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            /*
            */
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure one-to-many relationship for Category entities
            CategoryRelationSheip.CategoryRelationSheipToMany(modelBuilder);
            // Configure one-to-many relationship for Advertisement entities
            AdvertisementRelationSheip.AdvertisementRelationSheipToMany(modelBuilder);
            // Configure one-to-many relationship between Advertisements and User
            // Each Advertisement is associated with one User, and each User can have many Advertisements
             modelBuilder.Entity<Advertisements>()
                .HasOne(ad => ad.User)
                .WithMany(u => u.Advertisements)
                .HasForeignKey(ad => ad.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            // Configure one-to-one relationship between UserProfiles and User
            // Each UserProfiles entity is associated with one User, and vice versa
            // UserProfiles uses UserLoginId as the foreign key
            modelBuilder.Entity<UserProfiles>()
                .HasOne(up => up.User)
                .WithOne(ui => ui.UserProfiles)
                .HasForeignKey<UserProfiles>(up => up.UserLoginId);
        }
        public DbSet<User> User { get; set; }
        public DbSet<Advertisements> Advertisements { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<UserProfiles> UserProfiles { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Animals> Animals { get; set; }
        public DbSet<Electronics> Electronics { get; set; }
        public DbSet<Furniture> Furnitures { get; set; }
        public DbSet<Kitchen> Kitchens { get; set; }
        public DbSet<Sports> Sports { get; set; }
        public DbSet<Images> Images { get; set; }

    }
}
