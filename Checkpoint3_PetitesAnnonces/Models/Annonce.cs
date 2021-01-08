using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkpoint3_PetitesAnnonces.Models
{
    public class Annonce
    {
        public int Annonce_Id { get; set; }
        public string Title { get; set; }
        public string ObjectForSale { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public User user { get; set; }



    }
}
