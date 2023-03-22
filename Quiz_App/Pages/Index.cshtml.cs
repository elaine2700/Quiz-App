using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Quiz_App.Models;
using Quiz_App.Services;

namespace Quiz_App.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public List<Quiz> quizzes { get; set; }
    public JSONFileQuizService QuizService { get; private set; }
    

    [BindProperty]
    public int selectedQuiz { get; set; }

    public IndexModel(ILogger<IndexModel> logger, JSONFileQuizService _quizService)
    {
        _logger = logger;
        QuizService = _quizService;
        quizzes = new List<Quiz>();
    }

    public void OnGet()
    {
        var temp = QuizService.GetQuizData();
        if (temp == null) return;
        foreach(Quiz quiz in temp)
        {
            quizzes.Add(quiz);
        }

    }

    
}

