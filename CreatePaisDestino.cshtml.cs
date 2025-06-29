using AT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT.Pages
{
    public class CreatePaisDestinoModel : PageModel
    {
        [BindProperty]
        public PaisDestino Pais { get; set; }

        public string Mensagem { get; set; }

        public void OnGet()
        {
            Pais = new PaisDestino();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            Mensagem = $"País \"{Pais.Nome}\" com código \"{Pais.Codigo}\" cadastrado com sucesso!";
            return Page();
        }
    }
}
