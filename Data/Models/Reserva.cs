using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hotelAPI.Data.Models
{
    public class Reserva
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReservaId { get; set; }
        [Required]
        public string Cpf { get; set; }
        [ForeignKey("Quarto")]
        public int QuartoId { get; set; }
        public Quarto Quarto { get; set; } 
        [Required]
        public int NumeroDiarias { get; set; }

        
        public double PrecoTotal { get => Quarto != null ? Quarto.PrecoDiaria * NumeroDiarias : 0;}
    }
}
