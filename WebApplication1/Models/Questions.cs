// WebApplication1/Models/Question.cs
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Difficulty { get; set; }
        public IList<string> Options { get; set; }
        public string CorrectAnswer { get; set; }

        public Question()
        {
            Content = "";
            Difficulty = "";
            Options = new List<string>();
            CorrectAnswer = "";
        }
    }
}
