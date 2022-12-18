using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeRazorPages.Pages;

public class UserSettingsModel : PageModel
{

  public void OnGet()
  {
    Settings.UserId = "shawn@aol.com";
    Settings.FullName = "Shawn Wildermuth";
  }

  [BindProperty]
  public UserSettings Settings { get; set; } = new UserSettings();

  public void OnPost()
  {
    var UserId = Settings.UserId;
    if (UserId is null)
    {
      throw new InvalidDataException("UserId can't be null");
    }
  }
}

public class UserSettings
{
  public string? UserId { get; set; }
  public string? FullName { get; set; }
}
 
