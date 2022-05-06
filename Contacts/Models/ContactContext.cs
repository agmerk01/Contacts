using Microsoft.EntityFrameworkCore;

namespace ContactList.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
        : base(options)
        { }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Coworker" },
                new Category { CategoryId = 2, Name="Friend"},
                new Category { CategoryId=3,Name="Family"}
                );
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactID = 1,
                    FName = "Jerry",
                    LName = "Tuesday",
                    Email = "jerry@email.com",
                    Phone=1234567,
                    Organization = "redteam",
                    CategoryID = 1
                }
                );
        }
    }
}