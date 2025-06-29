using AT.Delegates_Eventos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AT.Models
{
    public class CidadeDestino
    {
        public int Id { get; set; }


        [ForeignKey("PaisDestino")]
        public int PaisDestinoId { get; set; }


        [Required(ErrorMessage = "O nome é obrigatório.")]
        [MinLength(3, ErrorMessage = "O nome deve ter pelo menos 3 caracteres.")]
        public string Nome { get; set; }
        public List<PacoteTuristico> Pacotes { get; set; } = new();
    }
}