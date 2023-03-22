using System;
namespace Quiz_App.Models
{
    public class Quiz
    {
        public List<Question>? questions { get; private set; }
        public string? Title { get; set; }
        public int currentQuestion { get; set; }
        public int correctAnswers { get; set; }
        
        public Quiz()
		{
            questions = new List<Question>();
            currentQuestion = 0;
            correctAnswers = 0;
        }

		public void AddQuestion(Question _question)
		{
            if (questions == null)
                questions = new List<Question>();
            questions.Add(_question);
		}

        public double CalculateScore()
        {
            if (questions == null) return 0;
            return (correctAnswers * 100) / questions.Count;
        }

	}
}

