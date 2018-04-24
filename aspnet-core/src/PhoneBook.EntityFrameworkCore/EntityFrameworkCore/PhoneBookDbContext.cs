using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using PhoneBook.Authorization.Roles;
using PhoneBook.Authorization.Users;
using PhoneBook.MultiTenancy;
using PhoneBook.PhoneBooks.Persons;
using PhoneBook.PhoneBooks.PhoneNumbers;

namespace PhoneBook.EntityFrameworkCore
{
    public class PhoneBookDbContext : AbpZeroDbContext<Tenant, Role, User, PhoneBookDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PhoneBookDbContext(DbContextOptions<PhoneBookDbContext> options)
            : base(options)
        {
        }

        public DbSet<PagedResultDto> Persons { get; set; }

        public DbSet<PhoneNumber> PhoneNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PagedResultDto>().ToTable("AbpPerson");
            modelBuilder.Entity<PhoneNumber>().ToTable("AbpPhoneNumber");
            base.OnModelCreating(modelBuilder);
        }
    }
}
