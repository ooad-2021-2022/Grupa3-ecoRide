using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MindHealth.Models
{
    public class Korisnik
    {
        [Key]
        public int Id { get; set; }
        public string ocjena { get; set; }
        public string komentar { get; set; }


        [ForeignKey("korisnik")]
        public Korisnik korisnik { get; set; }

        public Korisnik()
        { }

    }

}