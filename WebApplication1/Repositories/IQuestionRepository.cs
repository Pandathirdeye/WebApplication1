using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public interface IQuestionRepository
    {
        List<Question> GetQuestions(string difficultyLevel);
    }
}
