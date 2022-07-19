using Microsoft.EntityFrameworkCore;
using StudyDotnetWebAPI.Models;

namespace StudyDotnetWebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<PeopleHero> PeopleHeroes { get; set; }
    }
}