using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Learning.Razor.Pages.Forms
{
    public class CollectionsRequestFormModel : PageModel
    {
        [BindProperty]
        public int[] CategoriesIds { get; set; } = new int[0];

        public void OnGet()
        {

        }

        public void OnPost()
        {
            ViewData["CategoriesIds"] = CategoriesIds;
        }
    }
}