using Microsoft.EntityFrameworkCore;
using Test.Models;

namespace Test.Data
{
public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {}
        public DbSet<Record> Record { get;set; }
    }
}