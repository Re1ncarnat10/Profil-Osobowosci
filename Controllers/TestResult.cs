using Microsoft.AspNetCore.Mvc.RazorPages;
using Profil_Osobowosci.AppDbConext;
namespace Profil_Osobowosci.Controllers;
using Microsoft.AspNetCore.Mvc;
using Models;
using Microsoft.AspNetCore.Identity; 


public class TestResult : PageModel
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<User> _userManager; 

    public TestResult(ApplicationDbContext context, UserManager<User> userManager)
    {
        _context = context;
        _userManager = userManager; 

    }

    [BindProperty]
    public string Comment { get; set; }

    public string Result { get; set; }

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!string.IsNullOrEmpty(Comment))
        {
            var input = new MLModel.ModelInput { Posts = Comment };
            var output = MLModel.Predict(input);
            Result = output.PredictedLabel;

            var testResult = new PersonalityTestResult 
            {
                Comment = Comment,
                Result = Result,
                UserId = _userManager.GetUserId(User) // Add this line

            };

            _context.PersonalityTestResults.Add(testResult);
            await _context.SaveChangesAsync();
        }

        return Page();
    }
}