﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Quiz_App.Models;
using Quiz_App.Services;

namespace Quiz_App.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public IEnumerable<Quiz>? quizzes { get; set; }
    public JSONFileQuizService QuizService { get; private set; }
    

    [BindProperty]
    public int selectedQuiz { get; set; }

    public IndexModel(ILogger<IndexModel> logger, JSONFileQuizService _quizService)
    {
        _logger = logger;
        quizzes = new List<Quiz>();
        QuizService = _quizService;
    }

    public void OnGet()
    {
        quizzes = QuizService.GetQuizData();
        if (quizzes == null) quizzes = new List<Quiz>();
    }

    
}

