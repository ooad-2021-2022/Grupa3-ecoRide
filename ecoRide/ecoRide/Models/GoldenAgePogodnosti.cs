using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecoRide.Models
{
    public class GoldenAgePogodnosti
    {
        [Key]
        public int Id { get; set; }
        public string GoldenAgePogodnosti { get; set; }

    }
}