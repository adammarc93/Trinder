using Microsoft.EntityFrameworkCore;

using Trinder.API.Models;

namespace Trinder.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> option) : base(option)
        {
            
        }

        public DbSet<Value> Values { get; set; }
    }
}