using DVN.Models;
using Microsoft.EntityFrameworkCore;

namespace DVN.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // ================ user - role  | n - n 

        //     builder.Entity<UserRole>()
        //   .HasKey(e => new { e.UserId, e.RoleId }); 

        //     builder.Entity<UserRole>()
        //         .HasOne(ta => ta.User)
        //         .WithMany(t => t.UserRoles)
        //         .OnDelete(DeleteBehavior.Cascade);


        //     builder.Entity<UserRole>()           
        //         .HasOne(ta => ta.Role)
        //         .WithMany(t => t.UserRoles)
        //         .OnDelete(DeleteBehavior.Cascade);



        }


        // User 

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerEmail> CustomerEmails { get; set; }
        public DbSet<New> News { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<RegisterProduct> RegisterProducts { get; set; }
        public DbSet<Contact> Contacts { get; set; }


    }
}
