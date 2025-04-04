using AdressDataAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AdressDataAPI.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ContactInfo> Contacts { get; set; }
    }
}
