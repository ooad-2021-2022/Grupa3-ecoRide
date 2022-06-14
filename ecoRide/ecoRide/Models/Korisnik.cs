using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecoRide.Models
{
    public class Korisnik
    {
        public DateTime DatumRodjenja { get; set; }
        public string AdresaStanovanja { get; set; }
        public string BrojTelefona{ get; set; }
        public string BrojRacunaKorisnika { get; set; }
        public string BrojKredita { get; set; }
        public bool DaLiJeGoldenAge { get; set; }
        [ForeignKey("Lokacija")]
        public int LokacijaId { get; set; }
        public Lokacija Lokacija { get; set; }
        [ForeignKey("GoldenAgePogodnosti")]
        public int GoldenAgePogodnostiId { get; set; }
        public GoldenAgePogodnosti GoldenAgePogodnosti { get; set; }
        [ForeignKey("VrstaPlacanja")]
        public int VrstaPlacanjaId { get; set; }
        public VrstaPlacanja VrstaPlacanja { get; set; }
        [Key]
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }

    }
    
}