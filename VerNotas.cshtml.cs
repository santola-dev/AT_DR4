using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT.Pages
{
    public class VerNotasModel : PageModel
    {
        private readonly IWebHostEnvironment _env;

        public VerNotasModel(IWebHostEnvironment env)
        {
            _env = env;
        }

        [BindProperty]
        public string Conteudo { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ArquivoSelecionado { get; set; }

        public string CaminhoArquivos => Path.Combine(_env.WebRootPath, "files");

        public string[] ArquivosDisponiveis { get; set; } = [];

        public string ConteudoArquivo { get; set; }

        public void OnGet()
        {
            Directory.CreateDirectory(CaminhoArquivos);
            ArquivosDisponiveis = Directory.GetFiles(CaminhoArquivos, "*.txt")
                                           .Select(Path.GetFileName)
                                           .ToArray();

            if (!string.IsNullOrEmpty(ArquivoSelecionado))
            {
                string caminhoCompleto = Path.Combine(CaminhoArquivos, ArquivoSelecionado);

                if (System.IO.File.Exists(caminhoCompleto))
                {
                    ConteudoArquivo = System.IO.File.ReadAllText(caminhoCompleto);
                }
            }
        }

        public IActionResult OnPost()
        {
            Directory.CreateDirectory(CaminhoArquivos);

            string nomeArquivo = $"nota_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            string caminhoCompleto = Path.Combine(CaminhoArquivos, nomeArquivo);

            System.IO.File.WriteAllText(caminhoCompleto, Conteudo ?? string.Empty);

            return RedirectToPage(new { ArquivoSelecionado = nomeArquivo });
        }
    }
}
