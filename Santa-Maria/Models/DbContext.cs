using Microsoft.EntityFrameworkCore;
using System;

namespace Santa_Maria.Models
{
    public class DbContext
    {
        public DbContext(DbContextOptions<EscuelaContext> options)
        {
            Options = options;
        }

        public DbContextOptions<EscuelaContext> Options { get; }

        internal void OnModelCreating(ModelBuilder modelBuilder)
        {
            throw new NotImplementedException();
        }
    }
}