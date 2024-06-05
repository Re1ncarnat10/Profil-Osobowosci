using Microsoft.AspNetCore.Mvc.RazorPages;
using Profil_Osobowosci.AppDbConext;
namespace Profil_Osobowosci.Controllers;
using Microsoft.AspNetCore.Mvc;
using Profil_Osobowosci.Models;


public class TestResult : PageModel
{
    private readonly ApplicationDbContext _context;

    public TestResult(ApplicationDbContext context)
    {
        _context = context;
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
                Result = Result
            };

            _context.PersonalityTestResults.Add(testResult);
            await _context.SaveChangesAsync();
        }

        return Page();
    }
}