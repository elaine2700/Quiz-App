using System;
using System.Reflection.PortableExecutable;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using Quiz_App.Models;

namespace Quiz_App.Services
{
	public class JSONFileQuizService
	{

        public JSONFileQuizService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "quiz_data.json");

        public IEnumerable<Quiz>? GetQuizData()
        {
            using var jsonFileReader = File.OpenText(JsonFileName);
            return JsonSerializer.Deserialize<Quiz[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }) ;

        }
    }
}

