using Contacts.EfStuff.DbModel;
using Microsoft.EntityFrameworkCore;

namespace Contacts.EfStuff
{
    public class WebContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public WebContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
