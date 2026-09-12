# :LAURENCE LLORENTE – BSIT31E2

## IT Elective 2 – Web System and Technologies
### Prefinal Examination – MVC Application

This repository contains an ASP.NET Core MVC application that displays the 20 multiple-choice
prefinal exam questions along with the selected answers.

## Project Structure
- `Models/QuestionAnswer.cs` – model holding each question, its choices, and the answer
- `Controllers/HomeController.cs` – loads all 20 questions/answers into the view
- `Views/Home/Index.cshtml` – displays each question with its choices and highlights the answer

## How to Run
```
dotnet restore
dotnet run
```
Then open the URL shown in the terminal (e.g. `https://localhost:5001`).

## Notes
- No database is used — all data is stored in-memory in the controller.
- Built following MVC pattern as required by the exam instructions.
