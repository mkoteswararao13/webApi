using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WEBCORE.Pages
{
    public class EMPModel : PageModel
    {
        [BindProperty(SupportsGet =true)]
        public string fname { get; set; }
        public IActionResult OnGetAsync()

        {
            fname = "koti";
            return Page();

        }
        public IActionResult OnPostAsync()

        {
            fname = "koti";
            return Page();

        }

        public IActionResult OnPostDeleteAsync()

        {
            fname = "koti";
            return Page();

        }
    }
}