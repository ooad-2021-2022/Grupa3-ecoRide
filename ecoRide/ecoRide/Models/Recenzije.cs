using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecoRide.Models
{
    public class Recenzije
    {
        [Key]
        public int Id { get; set; }
        public string ocjena { get; set; }
        public string komentar { get; set; }


        [ForeignKey("korisnik")]
        public Korisnik korisnik { get; set; }

    }

}