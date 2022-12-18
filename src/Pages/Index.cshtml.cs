// Index.cshtml.cs
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeRazorPages.Pages;

public class IndexModel : PageModel
{

  public string Title { get; set; } = "Welcome";
  public List<double> InvoiceTotals { get; set; } = new List<double>();

  public void OnGet()
  {
    for (var x = 0; x < 10; ++x)
    {
      InvoiceTotals.Add(Random.Shared.NextDouble() * 100);
    }
  }
}