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
    }
}
