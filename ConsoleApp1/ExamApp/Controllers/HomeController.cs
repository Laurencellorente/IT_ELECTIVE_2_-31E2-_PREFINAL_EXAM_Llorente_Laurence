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
                new() { Number = 3, Question = "What is the primary purpose of Entity Framework Core?", Choices = new[]{"To create HTML pages automatically","To replace the MVC Controller","To map objects in code to relational database data","To replace the C# compiler"}, Answer = "C" },
                new() { Number = 4, Question = "Which EF Core component is primarily responsible for communicating with the database?", Choices = new[]{"DbContext","DbSetView","ControllerContext","RazorContext"}, Answer = "A" },
                new() { Number = 5, Question = "What does the command 'dotnet ef dbcontext scaffold' primarily do?", Choices = new[]{"Deletes the database","Creates a new MVC project","Generates EF Core models and a DbContext from an existing database","Starts the MVC application"}, Answer = "C" },
                new() { Number = 6, Question = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?", Choices = new[]{"Program.cs only","appsettings.json","Index.cshtml","Student.cs"}, Answer = "B" },
                new() { Number = 7, Question = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?", Choices = new[]{"One-to-One","One-to-Many","Many-to-Many","Many-to-One only"}, Answer = "B" },
                new() { Number = 8, Question = "In 'public int SectionId { get; set; }', what is SectionId?", Choices = new[]{"Primary key of Student","Foreign key referencing Section","Navigation property","Database connection string"}, Answer = "B" },
                new() { Number = 9, Question = "What is the purpose of a navigation property such as 'public Section Section { get; set; }'?", Choices = new[]{"It stores the database password","It represents a relationship to another entity","It creates a new database","It validates the student's name"}, Answer = "B" },
                new() { Number = 10, Question = "What does .Include() generally allow EF Core to do?", Choices = new[]{"Delete the Section table","Load related Section data together with Students","Create a new Student","Validate Student input"}, Answer = "B" },
                new() { Number = 11, Question = "Why might a ViewModel be used when displaying Student and Section information?", Choices = new[]{"To replace the database","To combine or shape the data specifically needed by the view","To automatically create database tables","To prevent controllers from using LINQ"}, Answer = "B" },
                new() { Number = 12, Question = "In '_context.Students.Include(s => s.Section).ToList()', what is the main benefit of Include(s => s.Section)?", Choices = new[]{"It loads the related Section navigation property","It creates a Section object manually","It removes the foreign key","It prevents the query from accessing the database"}, Answer = "A" },
                new() { Number = 13, Question = "Which type of validation occurs in the browser before a request is sent to the server?", Choices = new[]{"Database-level validation","Client-side validation","Server-side validation","EF Core migration validation"}, Answer = "B" },
                new() { Number = 14, Question = "Why is server-side validation still necessary if client-side validation exists?", Choices = new[]{"Client-side validation can be bypassed","Client-side validation automatically modifies the database","Server-side validation only works with SQLite","Client-side validation cannot display messages"}, Answer = "A" },





















            };
                return View(answers);
            }
        }
    }
}