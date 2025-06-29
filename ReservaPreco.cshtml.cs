using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT.Delegates_Eventos
{
    public class ReservaPrecoModel : PageModel
        {
        [BindProperty]
        public int QuantidadePessoas { get; set; }

        [BindProperty]
        public decimal PrecoPorPessoa { get; set; }

        public decimal ValorTotal { get; set; }

        public void OnPost()
        {
            Func<int, decimal, decimal> calcularTotal = (qtd, preco) => qtd * preco;
            ValorTotal = calcularTotal(QuantidadePessoas, PrecoPorPessoa);
        }
    }
}
