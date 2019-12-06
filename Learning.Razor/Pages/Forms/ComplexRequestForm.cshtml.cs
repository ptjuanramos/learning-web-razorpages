using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Learning.Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Learning.Razor.Pages.Forms
{
    public class ComplexRequestFormModel : PageModel
    {
        [BindProperty]
        public User FormUser { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            ViewData["welcome"] = $"Welcome {FormUser.Name} - {FormUser.Email}";
        }
    }
}