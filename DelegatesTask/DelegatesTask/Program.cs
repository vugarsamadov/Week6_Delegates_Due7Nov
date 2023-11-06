using DelegatesTask.Extensions;
using DelegatesTask.Helpers;
using DelegatesTask.Models;
using System.Data;

Student student1 = new("Vugar","Samadov");
Student student2 = new("Bill","Clinton");
Student student3 = new("Saddam","Hussein");
Student student4 = new("Jefy","Biden");
Student student5 = new("Hunter","Biden");


List<Exam> ExamResults = new List<Exam>();

int command;

do
{
    command = InputHelper.PromptAndGetPositiveInt(InputHelper.Command);

    switch (command)
    {
        case 1:
            ExamResults.Add(InputHelper.PromptAndGetExamResult());
            break;
        case 2:
            break;
        default:
            Console.WriteLine("Invalid input!");
            break;
    }
} while (command != 2);


ExamResults.FindAll(e => e.Point > 50).Dump("Pointi 50-den yuxari olanlar: ");
ExamResults.FindAll(e => (DateTime.Now - e.StartDate).Days <= 7).Dump("Son bir hefte erzinde bas veren examlar: ");
ExamResults.FindAll(e => e.Duration > 1).Dump("Durationu 1 saatdan cox olanlar");