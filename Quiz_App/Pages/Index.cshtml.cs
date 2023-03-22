using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Quiz_App.Models;

namespace Quiz_App.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public List<Quiz> quizzes { get; set; } = new List<Quiz>();

    [BindProperty]
    public int selectedQuiz { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    
    }

    public void OnGet()
    {
        // Create the four quizzes
        quizzes = new List<Quiz>();
        for(int i= 0; i < 3; i++)
        {
            quizzes.Add(new Quiz());
        }

        // Create the questions for every quiz

        // Quiz 1 
        quizzes[0].Title = "Some Title";

        quizzes[0].AddQuestion(
            new Question(
            "What CSS stands for?",
            new string[] {
                "Cascading Style Sheets",
                "Colorful System Systematic",
                "Charismatics Stylistic Site",
                "Cascades System Star" },
            1)
            );

        quizzes[0].AddQuestion(
            new Question(
            "What is 4 + 4",
            new string[] { "Hello",
                "8",
                "24",
                "I don't know"},
            4)
            );

        quizzes[0].AddQuestion(
            new Question(
            "What is 4 + 4",
            new string[] { "Hello",
                "8",
                "24",
                "I don't know"},
            4)
            );


        // Quiz 2

        quizzes[1].Title = "Second Quiz";

        quizzes[1].AddQuestion(
            new Question(
            "Can you answer this?",
            new string[] {
                "Maybe",
                "I don't want to",
                "Yes, definitely",
                "Oh no!" },
            1)
            );

        quizzes[1].AddQuestion(
            new Question(
            "What is 4 + 4",
            new string[] {
                "Hello",
                "8",
                "24",
                "I don't know"},
            4)
            );

        quizzes[1].AddQuestion(
            new Question(
            "What is 4 + 5",
            new string[] {
                "9",
                "8",
                "24",
                "I don't know"},
            4)
            );

        // Quiz 3
        quizzes[2].Title = "Third Quiz";

        quizzes[2].AddQuestion(
            new Question(
            "What other question to answer?",
            new string[] {
                "Maybe",
                "I don't want to",
                "Yes, definitely",
                "Oh no!" },
            1)
            );

        quizzes[2].AddQuestion(
            new Question(
            "Are you there",
            new string[] {
                "Hello",
                "8",
                "24",
                "I don't know"},
            4)
            );

        quizzes[2].AddQuestion(
            new Question(
            "Is this correct",
            new string[] {
                "9",
                "8",
                "24",
                "I don't know"},
            4)
            );


    }
}

