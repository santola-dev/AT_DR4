using AT.Delegates_Eventos;
using System.ComponentModel.DataAnnotations;

namespace AT.Models
{
    public class PacoteTuristico
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Titulo { get; set; }

        public DateTime DataInicio { get; set; }

        [Range(1, int.MaxValue)]
        public int CapacidadeMaxima { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal Preco { get; set; }

        public List<CidadeDestino> Destinos { get; set; } = new();

        public List<Reserva> Reservas { get; set; } = new();
    }
}

