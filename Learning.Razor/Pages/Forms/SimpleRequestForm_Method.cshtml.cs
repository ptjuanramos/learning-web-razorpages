using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Learning.Razor.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Learning.Razor.Pages
{
    public class SimpleRequestForm_MethodModel : PageModel
    {
        public void OnGet()
        {

        }

        public void OnPost(string name, string email)
        {
            if (!ValidationHelper.IsEmailValid(email))
            {
                ViewData["errorMessage"] = $"Email: {email} is invalid";
            } else
            {
                string message = $"{name} with his {email}";
                ViewData["resultMessage"] = message;
            }
        }
    }
}