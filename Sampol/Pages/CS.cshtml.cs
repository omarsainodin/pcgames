using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sampol.Pages
{
    public class CSModel : PageModel
    {
        private readonly ILogger<CSModel> _logger;

        public CSModel(ILogger<CSModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}