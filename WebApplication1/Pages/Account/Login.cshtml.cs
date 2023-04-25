using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace WebApplication1.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Creds Creds { get; set; }
        public void OnGet()
        {
           
        }

        public void OnPost()
        {
            if (!ModelState.IsValid) return;

        }
    }

    public class Creds
    {
        [Required]
        [Display(Name="User Name")]
        public string userName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


    }
}

