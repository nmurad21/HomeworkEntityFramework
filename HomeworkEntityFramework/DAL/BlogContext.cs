using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkEntityFramework.Models
{
    class BlogContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=WIN-CUEGFOLCMBN;Initial Catalog=Blog;Integrated Security=SSPI;");
        }
        public DbSet<Post> Posts {get;set;}
    }
}
