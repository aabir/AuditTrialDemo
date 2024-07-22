using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AuditTrialDemo.Models;
using Microsoft.AspNetCore.Http;

namespace AuditTrialDemo.Data
{
    public class ApplicationDbContext : AuditableIdentityContext
    {
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AuditTrialDemo.Models.Product> Product { get; set; } = default!;
    }
}
