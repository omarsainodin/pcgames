using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sampol.Pages
{
    public class ALModel : PageModel
    {
        private readonly ILogger<ALModel> _logger;

        public ALModel(ILogger<ALModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}