using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecoRide.Models
{
    public class Lokacija
    {
        [Key]
        public int Id { get; set; }
        public string geografskaSirina { get; set; }
        public string geografskaDuzina { get; set; }
        public string imeLokacije { get; set; }
       
        public string adresa { get; set; }
      

    }
    
}