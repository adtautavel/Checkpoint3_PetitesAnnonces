using Checkpoint3_PetitesAnnonces.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkpoint3_PetitesAnnonces
{
    public class PetitesAnnoncesContext : DbContext
    {
        public virtual DbSet<Annonce> Annonces { get; set; }
        public virtual DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=LOCALHOST\SQLEXPRESS;Database=PetitesAnnonces;Integrated Security=True");


        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Annonce>()
                .HasKey(a => new { a.Annonce_Id });
            builder.Entity<User>()
                .HasKey(u => new { u.User_id });
        }
    }
}
