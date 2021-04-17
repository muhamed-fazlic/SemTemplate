using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class RepositoryContext: DbContext
    {
        public RepositoryContext(DbContextOptions options)
 : base(options)
        {
        }
        public DbSet<Proizvod> Proizvodi { get; set; }
        public DbSet<Adresa> Adrese { get; set; }
    }
}
