using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplication.Pages
{

    public class ComplexType
    {
        // [ValidateNever]
        public Maybe<string> MaybeField { get; set; }
    }
    
    public class IndexModel : PageModel
    {
        [BindProperty]
        public ComplexType ComplexType { get; set; }
        
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            return RedirectToPage();
        }
    }
}