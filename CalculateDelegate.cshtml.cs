using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT.Delegates_Eventos
{
    public class DescontoModel : PageModel
    {
        [BindProperty]
        public decimal PrecoOriginal { get; set; }

        public decimal PrecoComDesconto { get; set; }

        public void OnPost()
        {
            CalculateDelegate calcular = new CalculateDelegate(DescontoHelper.AplicarDesconto);

            PrecoComDesconto = calcular(PrecoOriginal);
        }
    }
}
