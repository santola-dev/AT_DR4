using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AT.Data;
using AT.Models;
using Microsoft.AspNetCore.Authorization;
namespace AT.Pages
{
    
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly AT.Data.AgenciaTurismoContext _context;

        public IndexModel(AT.Data.AgenciaTurismoContext context)
        {
            _context = context;
        }

        public IList<Cliente> Cliente { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Cliente = await _context.Clientes
                .Where(c => c.DeletedAt == null)
                .ToListAsync();
        }

    }
}
