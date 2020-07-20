using Microsoft.EntityFrameworkCore;
using mvc_Migration.Models;

namespace mvc_Migration
{
    public class EmailContext : DbContext 
    {
        public EmailContext(DbContextOptions<EmailContext> options)
            : base(options) { }

             public DbSet<Email> Emails { get; set; }
    }
    
}