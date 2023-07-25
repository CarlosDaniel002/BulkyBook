using Microsoft.EntityFrameworkCore;
using BulkyBook.Web.Models;

namespace BulkyBook.Web.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {   
        }

        public DbSet<Category> Categories { get; set; }
    }
}
