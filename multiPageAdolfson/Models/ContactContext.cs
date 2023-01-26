using Microsoft.EntityFrameworkCore;

namespace multiPageAdolfson.Models
{
    public class ContactContext : DbContext
    {

        public ContactContext() { }

        public ContactContext (DbContextOptions<ContactContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(

                new Contact
                {
                    ContactId = 1,
                    Name = "Antony Adolfson",
                    phoneNumber = 1234567890,
                    address = "123 Main Street",
                    note = "Example of additional information"
                },

                new Contact
                {
                    ContactId = 2,
                    Name = "Brindle",
                    phoneNumber = 1111111111,
                    address = "456 Harvest Rd",
                    note = "An amazing cat."
                },

                new Contact
                {
                    ContactId = 3,
                    Name = "VooDoo",
                    phoneNumber = 4564654566,
                    address = "789 Best Cat Ave",
                    note = "Fat, and a little troublemaker."
                }

                ); ;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Contacts;Integrated Security=true;MultipleActiveResultSets=true");
        }

    }
}
