using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecoRide.Models
{
    public class Lokacija
    {
        [Key]
        public int Id { get; set; }
        public string GeografskaSirina { get; set; }
        public string GeografskaDuzina { get; set; }
        public string ImeLokacije { get; set; }
        public string Adresa { get; set; }
      

    }
    
}