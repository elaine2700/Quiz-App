using System;
namespace Quiz_App.Models
{
	public class Question
	{
		public string question { get; set; }
		public string[] PossibleAnswers { get; set; }
		public int CorrectAnswer { get; set; }

		public Question(string _question, string[] _answers, int _correctAnswer)
		{
			question = _question;
			PossibleAnswers = _answers;
			CorrectAnswer = _correctAnswer;
		}

	}
}

