using System.ComponentModel.DataAnnotations;

namespace AT.Models
{
    public class PaisDestino
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do país é obrigatório.")]
        [MinLength(3, ErrorMessage = "O nome deve ter pelo menos 3 caracteres.")]

        public string Nome { get; set; }

        [Required(ErrorMessage = "O código do país é obrigatório.")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "O código deve ter exatamente 2 caracteres.")]
        public string Codigo { get; set; }

        public List<CidadeDestino> Cidades { get; set; } = new();
    }
}

