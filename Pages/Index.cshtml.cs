using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Profil_Osobowosci.Pages
{
        public class IndexModel : PageModel
        {
            public void OnGet()
            {
                ViewData["Title"] = "Home page";
                ViewData["BodyClass"] = "home-page";
            }
        }
    }

