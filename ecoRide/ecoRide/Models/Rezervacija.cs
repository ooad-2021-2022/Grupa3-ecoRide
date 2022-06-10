using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecoRide.Models
{
    public class Rezervacija
    {
        [Key]
        public int Id { get; set; }
        public DateTime vrijeme { get; set; }

        [ForeignKey("Vozilo")]
        public int Vozilo { get; set; }
        
        public Lokacija lokacija { get; set; }
    }
}