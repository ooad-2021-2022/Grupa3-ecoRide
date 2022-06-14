using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecoRide.Models
{
    public class Izvjestaj
    {
        [Key]
        public int Id { get; set; }
        public int BrojPotrosenihKalorija { get; set; }
        public string UstedaNovca { get; set; }
        public string SmanjenjeEmisijeCO2 { get; set; }

        [ForeignKey("Korisnik")]
        public Korisnik Korisnik { get; set; }
   
    }

}