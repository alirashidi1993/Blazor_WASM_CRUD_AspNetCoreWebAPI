using BlazorCrudApp.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudApp.Server.AppDbContext
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
    }
}
