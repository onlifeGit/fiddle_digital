using fiddle_digital.Models.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiddle_digital.Models
{
    public class SqlContext : DbContext
    {
        public DbSet<Project> Projects { set; get; }

        public DbSet<ContactForm> ContactForms { set; get; }

        public DbSet<Article> Articles { set; get; }

        public DbSet<ServiceEmail> ServiceEmails { set; get; }

        public DbSet<User> Users { set; get; }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
