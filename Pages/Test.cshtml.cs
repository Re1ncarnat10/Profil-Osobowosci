using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Profil_Osobowosci;

public class TestModel : PageModel
{
    [BindProperty]
    public string Comment { get; set; }

    public string Result { get; set; }

    public void OnGet()
    {
    }

    public void OnPost()
    {
        if (!string.IsNullOrEmpty(Comment))
        {
            var input = new MLModel.ModelInput { Posts = Comment };
            var output = MLModel.Predict(input);
            Result = output.PredictedLabel;
        }
    }
}
