using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace practicaProto.models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        
        public DbSet<Company> Company { get; set; }

    }
}