using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sampol.Pages
{
    public class LolModel : PageModel
    {
        private readonly ILogger<LolModel> _logger;

        public LolModel(ILogger<LolModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}