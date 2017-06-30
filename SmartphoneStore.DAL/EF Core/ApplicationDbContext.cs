using Microsoft.EntityFrameworkCore;
using SmartphoneStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartphoneStore.DAL.EF_Core
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
