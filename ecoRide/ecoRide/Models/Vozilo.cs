using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecoRide.Models
{
    public class Vozilo
    {
        [Key]
        public int Id { get; set; }
        public string cijenaKarte { get; set; }

        [ForeignKey("VrstaVozila")]
        public VrstaVozila vrstaVozila { get; set; }

        public int VrstaVozila { get; set; }

    }
}