using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace WebApplication1.Pages
{
    public class BasicConceptsModel : PageModel
    {
        public List<Question> Questions { get; set; }

        public BasicConceptsModel()
        {
            Questions = new List<Question>()
            {
                new Question
                {
                    Text = "What is the most commonly used type of network cabling?",
                    Answers = new List<string>
                    {
                        "Fiber optic cable",
                        "Coaxial cable",
                        "Unshielded twisted pair (UTP) cable"
                    },
                    CorrectAnswer = "Unshielded twisted pair (UTP) cable"
                },
                new Question
                {
                    Text = "What is the purpose of a punch down tool in network wiring?",
                    Answers = new List<string>
                    {
                        "To strip the outer jacket of a cable",
                        "To crimp the connectors onto the cable",
                        "To connect the wires to the keystone jack or patch panel"
                    },
                    CorrectAnswer = "To connect the wires to the keystone jack or patch panel"
                },
                new Question
                {
                    Text = "Who discovered penicillin?",
                    Answers = new List<string>
                    {
                        "Marie Curie",
                        "Alexander Fleming",
                        "Albert Einstein"
                    },
                    CorrectAnswer = "Alexander Fleming"
                },
                new Question
                {
                    Text = "What is the largest ocean in the world?",
                    Answers = new List<string>
                    {
                        "Indian Ocean",
                        "Atlantic Ocean",
                        "Pacific Ocean"
                    },
                    CorrectAnswer = "Pacific Ocean"
                },
                new Question
                {
                    Text = "What is the smallest country in the world?",
                    Answers = new List<string>
                    {
                        "Vatican City",
                        "Monaco",
                        "San Marino"
                    },
                    CorrectAnswer = "Vatican City"
                },
                new Question
                {
                    Text = "What is the highest mountain in the world?",
                    Answers = new List<string>
                    {
                        "Mount Kilimanjaro",
                        "Mount Everest",
                        "Mount Fuji"
                    },
                    CorrectAnswer = "Mount Everest"
                }
            };
        }
    }

    public class Question
    {
        public string Text { get; set; }
        public List<string> Answers { get; set; }
        public string CorrectAnswer { get; set; }
       
    }
}