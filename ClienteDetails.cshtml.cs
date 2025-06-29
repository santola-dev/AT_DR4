using AT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace AT.Pages
{
    public class ClienteDetailsModel : PageModel
    {
        public Cliente ClienteSelecionado { get; set; }

        private static List<Cliente> ClientesFake = new List<Cliente>
        {
            new Cliente { Id = 1, Nome = "Dante", Email = "dante@email.com" },
            new Cliente { Id = 2, Nome = "Vergil", Email = "vergil@email.com" },
            new Cliente { Id = 3, Nome = "Nero", Email = "nero@email.com" }
        };

        public IActionResult OnGet(int id)
        {
            ClienteSelecionado = ClientesFake.FirstOrDefault(c => c.Id == id);

            if (ClienteSelecionado == null)
                return NotFound();

            return Page();
        }
    }
}
