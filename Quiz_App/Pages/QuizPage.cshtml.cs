using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Quiz_App.Models;

namespace Quiz_App.Pages
{
    public class QuizPageModel : PageModel
    {
        public Quiz? quiz { get; set; } 


        public void OnGet()
        {
            
        }
    }
}
