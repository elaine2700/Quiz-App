using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Quiz_App.Models;
using Quiz_App.Services;

namespace Quiz_App.Pages
{
    public class QuizPageModel : PageModel
    {
        public JSONFileQuizService QuizService { get; private set; }
        public List<Quiz> quizzes { get; set; }

        public QuizPageModel(JSONFileQuizService _quizService)
        {
            QuizService = _quizService;
            quizzes = new List<Quiz>();
        }


        public void OnGet()
        {
            var temp = QuizService.GetQuizData();
            if (temp == null) return;
            foreach(var item in temp)
            {
                quizzes.Add(item);
            }
        }
    }
}
