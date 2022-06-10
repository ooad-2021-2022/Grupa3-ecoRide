using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecoRide.Models
{
    public class Korisnik
    {
        [Key]
     
        public string AdresaStanovanja { get; set; }
        public string brojTelefona{ get; set; }
        public string BrojRacunaKorisnika { get; set; }
        public DateTime datumRodjenja { get; set; }
        public int brojKredita { get; set; }
        public bool DaLiJeGoldenAge { get; set; }
        public int Rezervacija{ get; set; }
        public string Lokacija { get; set; }

        public string GoldenagePogodnosti { get; set; }
        public string preferiranoPlacanje { get; set; }
       
        public string id { get; set; }
        public int idKorisnika { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string email { get; set; }


        public Korisnik()
        { }

    }
    
}