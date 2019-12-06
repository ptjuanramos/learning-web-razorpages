using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Learning.Razor.Helpers;
using Learning.Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Learning.Razor.Pages
{
    public class SimpleRequestForm_RequestModel : PageModel
    {
        public void OnGet()
        {

        }

        public void OnPost()
        {
            string name = Request.Form["name"];
            string email = Request.Form["email"];
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