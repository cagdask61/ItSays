using ItSays.Core.Entities.Concrete;
using ItSays.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.DataAccess.Concrete.EntityFramework
{
    public class ItSaysContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ÇAĞDAŞKOCAMAN;Database=ItSaysContext;Trusted_Connection=true");
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<AuthorOperationClaim> AuthorOperationClaims { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Composer> Composers { get; set; }
    }
}
