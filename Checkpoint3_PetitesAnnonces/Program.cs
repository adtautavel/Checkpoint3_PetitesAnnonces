using Checkpoint3_PetitesAnnonces.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkpoint3_PetitesAnnonces
{
    public class Program
    {
        public static void Main(string[] args)
        {
           using (var context = new PetitesAnnoncesContext())
            {
               if (context.Database != null)
                { 
                    context.Database.EnsureDeleted();
                    context.Database.EnsureCreated();
                }
                
                User user1 = new User
                {
                    FirstName = "Jean-Michel",
                    LastName = "Animaler",
                };
                Annonce annonce1 = new Annonce
                {
                    Title = "Chien à vendre",
                    ObjectForSale = "Chien de cinéma",
                    Description = "Très peu joué, a fait qq pubs pour Canikro",
                    Owner = "DogMaster31",
                    Price = 5000,
                    Date = DateTime.Now,
                    user = user1,
                };
                context.Add(user1);
                context.Add(annonce1);
                context.SaveChanges();

            
            }
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
