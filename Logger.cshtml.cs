using AT.Delegates_Eventos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT.Delegates_Eventos
{
    public class LoggerModel : PageModel
    {
        [BindProperty]
        public string Mensagem { get; set; }

        public string Resultado { get; set; }

        public void OnPost()
        {
            Action<string> logAction = LoggerHelper.LogToConsole;
            logAction += LoggerHelper.LogToFile;
            logAction += LoggerHelper.LogToMemory;

            logAction(Mensagem);

            Resultado = "Mensagem registrada com sucesso.";
        }
    }
}
