using ExamApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExamApp.Controllers
{
    using global::IT_ELECTIVE_2_SECTION_PREFINAL_EXAM_Lastname_Firstname.Models;
    using Microsoft.AspNetCore.Mvc;

    namespace IT_ELECTIVE_2_SECTION_PREFINAL_EXAM_Lastname_Firstname.Controllers
    {
        public class HomeController : Controller
        {
            public IActionResult Index()
            {
                var answers = new List<QuestionAnswer>
            {
                new() { Number = 1, Question = "What is the main problem solved by using a database instead of an in-memory collection?", Choices = new[]{"It makes C# code shorter","It prevents the application from restarting","It allows data to persist after the application stops","It removes the need for MVC"}, Answer = "C" },
                new() { Number = 2, Question = "Which approach is being used when an existing database is used to generate EF Core entity classes?", Choices = new[]{"Code-First","Database-First","Model-First","Controller-First"}, Answer = "B" },





















            };
                return View(answers);
            }
        }
    }
}