using Microsoft.AspNetCore.Mvc;
using Profil_Osobowosci.Models;
using System.Threading.Tasks;

namespace Profil_Osobowosci.Controllers
{
    public class LoginAndRegisterController : Controller
    {
        // Dodaj tutaj zależność do serwisu obsługującego logowanie i rejestrację

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
            // Implementacja logiki rejestracji
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            // Implementacja logiki logowania
            return View();
        }
    }
}