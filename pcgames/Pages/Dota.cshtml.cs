using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sampol.Pages
{
    public class DotaModel : PageModel
    {
        private readonly ILogger<DotaModel> _logger;

        public DotaModel(ILogger<DotaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}