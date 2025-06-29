using AT.Delegates_Eventos;
using System.ComponentModel.DataAnnotations;

namespace AT.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        
        [Required]
        [MinLength(3)]
        public string Nome { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public List<Reserva> Reservas { get; set; } = new();

        public DateTime? DeletedAt { get; set; }
    }
}
