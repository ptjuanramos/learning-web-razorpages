using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Learning.Razor.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Learning.Razor.Pages
{
    public class SimpleRequestForm_PropertiesModel : PageModel
    {

        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Email { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (!ValidationHelper.IsEmailValid(Email))
            {
                ViewData["errorMessage"] = $"Email: {Email} is invalid";
            } else
            {
                string message = $"{Name} with his {Email}";
                ViewData["resultMessage"] = message;
            }
        }

    }
}