using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace ecoRide.Models
{
    public class Rezervacija
    {
        [Key]
        public int Id { get; set; }
        public DateTime Vrijeme { get; set; }
        public Lokacija Lokacija { get; set; }

        [ForeignKey("Korisnik")]
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }
    }
}