using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hotelAPI.Data.Models
{
    public class Quarto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuartoId { get; set; }
        public string Nome { set; get; }
        public double PrecoDiaria { get; set; }
    }
}
