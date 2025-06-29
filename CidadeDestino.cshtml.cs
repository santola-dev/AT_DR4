using AT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT.Pages
{
    public class CreateCidadeDestinoModel : PageModel
    {
        [BindProperty]
        public CidadeDestino CidadeDestino { get; set; }

        public string Resultado { get; set; }

        public void OnGet()
        {
            CidadeDestino = new CidadeDestino();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Resultado = $"Cidade \"{CidadeDestino.Nome}\" cadastrada com sucesso!";
            return Page();
        }
    }
}

