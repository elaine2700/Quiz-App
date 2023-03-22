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
        public int QuizIndex { get; private set; }
        public Quiz CurrentQuiz { get; private set; }

        public int CurrentQuestion { get; set; }

        public bool finishedQuiz { get; set; } = false;

        [BindProperty]
        public int userAnswer { get; set; }

        public QuizPageModel(JSONFileQuizService _quizService)
        {
            QuizService = _quizService;
            quizzes = new List<Quiz>();
            CurrentQuiz = new Quiz();
        }


        public void OnGet(int quizIndex, int? currentQuestion)
        {
            // Get Quiz from JSon Data
            var temp = QuizService.GetQuizData();
            if (temp == null) return;
            foreach(var item in temp)
            {
                quizzes.Add(item);
            }
            QuizIndex = quizIndex;
            CurrentQuiz = quizzes[QuizIndex];
            if (currentQuestion == null) return;
            if (currentQuestion >= CurrentQuiz.Questions.Count)
            {
                finishedQuiz = true;
                CurrentQuestion = 0;
            }
                
                
        }

        public void OnPost(int quizIndex, int currentQuestion)
        {
            var temp = QuizService.GetQuizData();
            if (temp == null) return;
            foreach (var item in temp)
            {
                quizzes.Add(item);
            }
            QuizIndex = quizIndex;
            CurrentQuiz = quizzes[QuizIndex];
            CurrentQuestion = currentQuestion;
            if (currentQuestion >= CurrentQuiz.Questions.Count)
            {
                finishedQuiz = true;
                CurrentQuestion = 0;
            }
                
        }

        
    }
}
