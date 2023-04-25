using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Pages
{
    public class Quiz3Model : PageModel
    {
        private readonly IQuestionRepository _questionRepository;
        public IList<Question>? Questions { get; set; }
        public IDictionary<int, string> UserAnswers { get; set; } = new Dictionary<int, string>();
        public int Score { get; set; }
        public bool IsSubmitted { get; set; }

        public Quiz3Model(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public void OnGet()
        {
            Questions = _questionRepository.GetQuestions("Advanced");
        }

        public void OnPost()
        {
            Questions = _questionRepository.GetQuestions("Advanced");
            Score = 0;
            IsSubmitted = true;

            foreach (var question in Questions)
            {
                if (UserAnswers.TryGetValue(question.Id, out var userAnswer) && userAnswer == question.CorrectAnswer)
                {
                    Score++;
                }
            }
        }
    }
}
