using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Profil_Osobowosci;
using Profil_Osobowosci.Models;
using Profil_Osobowosci.Data;

public class TestModel : PageModel
{
    private readonly AppDbContext _context;

    public TestModel(AppDbContext context)
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
            var mlOutput = MLModel.Predict(input);
            Result = mlOutput.PredictedLabel;

            var output = new Profil_Osobowosci.Models.ModelOutput
            {
                Posts = Comment,
                PredictedLabel = mlOutput.PredictedLabel,
                Score = mlOutput.Score,
                Type = mlOutput.Type
            };

            _context.ModelOutputs.Add(output);
            await _context.SaveChangesAsync();
        }

        return Page();
    }
}