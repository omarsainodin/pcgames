using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sampol.Pages
{
    public class ValoModel : PageModel
    {
        private readonly ILogger<ValoModel> _logger;

        public ValoModel(ILogger<ValoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}