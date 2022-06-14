using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecoRide.Models
{
    public class Vozilo
    {
        [Key]
        public int Id { get; set; }
        public string CijenaKarte { get; set; }

        [ForeignKey("VrstaVozila")]
        public VrstaVozila VrstaVozila { get; set; }

    }
}