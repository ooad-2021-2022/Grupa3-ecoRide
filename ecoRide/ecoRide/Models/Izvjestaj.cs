using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecoRide.Models
{
    public class Izvjestaj
    {
        [Key]
        public int Id { get; set; }
        public int brojPotrosenihKalorija { get; set; }
        public string ustedaNovca { get; set; }
        public string smanjenjeEmisijeCO2 { get; set; }

        [ForeignKey("korisnik")]
        public Korisnik korisnik { get; set; }
        

        public Korisnik()
        { }

    }

}