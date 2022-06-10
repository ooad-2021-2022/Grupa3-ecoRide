using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecoRide.Models
{
    public class VrstaPlacanja
    {
        [Key]
        public int Id { get; set; }
        public string VrstaPlacanja { get; set; }
        
         public Korisnik()
        { }

    }

}
