using System.Collections.Generic;
using System.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly string _connectionString;

        public QuestionRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Question> GetQuestions(string difficultyLevel)
        {
            var questions = new List<Question>();
            string tableName = "";

            switch (difficultyLevel.ToLower())
            {
                case "easy":
                    tableName = "EasyQuestions";
                    break;
                case "intermediate":
                    tableName = "IntermediateQuestions"; 
                    break;
                case "advanced":
                    tableName = "AdvancedQuestions";
                    break;
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT * FROM {tableName}", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var question = new Question
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("QuestionID")),
                                Content = reader.GetString(reader.GetOrdinal("Question")),
                                Difficulty = difficultyLevel,
                                Options = new List<string> { reader.GetString(reader.GetOrdinal("OptionA")), reader.GetString(reader.GetOrdinal("OptionB")), reader.GetString(reader.GetOrdinal("OptionC")), reader.GetString(reader.GetOrdinal("OptionD")) },
                                CorrectAnswer = reader.GetString(reader.GetOrdinal("Answer"))
                            };

                            questions.Add(question);
                        }
                    }
                }
            }

            return questions;
        }
    }
}
