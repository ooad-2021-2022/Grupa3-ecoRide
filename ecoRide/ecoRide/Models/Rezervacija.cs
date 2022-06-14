using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace ecoRide.Models
{
    public class Rezervacija
    {
        [Key]
        public int Id { get; set; }
        public DateTime vrijeme { get; set; }
        public Lokacija lokacija { get; set; }

        [ForeignKey("Korisnik")]
        public int KorisnikID { get; set; }
        public Korisnik Korisnik { get; set; }
    }
}