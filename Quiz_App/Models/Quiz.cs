using System;
using System.Text.Json.Serialization;

namespace Quiz_App.Models
{
    public class Quiz
    {
        [JsonPropertyName("Title")]
        public string? Title { get; set; }

        [JsonPropertyName("Questions")]
        public IEnumerable<Question>? Questions { get; set; }

        [JsonPropertyName("img")]
        public string? Image { get; set; }

        public int currentQuestion { get; set; }
        
	}

    public class Question
    {
        [JsonPropertyName("question")]
        public string? question { get; set; }

        [JsonPropertyName("answers")]
        public List<string>? PossibleAnswers { get; set; }

    }
}

