using DelegatesTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTask.Helpers
{
    internal class InputHelper
    {
        public const string Command = @"1 -> Add Result
2 -> Quit

Enter command:
";

        public static string PromptAndGetNonEmptyString(string prompt)
        {
            string input = null;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input) || input == string.Empty)
                    Console.WriteLine("Empty input is not allowed!");

            } while (String.IsNullOrWhiteSpace(input) || input == string.Empty);

            return input;
        }

        public static int PromptAndGetPositiveInt(string prompt)
        {
            int input = 0;
            bool IsSuccess;
            do
            {

                IsSuccess = Int32.TryParse(PromptAndGetNonEmptyString(prompt), out input);

                if (input < 0)
                    Console.WriteLine("Positive input is required!");
                if (!IsSuccess)
                    Console.WriteLine("Format is wrong!");

            } while (input < 0 || !IsSuccess);

            return input;
        }

        public static double PromptAndGetPositiveDouble(string prompt)
        {
            double input = 0;
            bool IsSuccess;
            do
            {
                
                IsSuccess = Double.TryParse(PromptAndGetNonEmptyString(prompt), out input);

                if (input < 0)
                    Console.WriteLine("Positive input is required!");
                if(!IsSuccess)
                    Console.WriteLine("Format is wrong!");

            } while (input < 0 || !IsSuccess);

            return input;
        }


        public static DateTime PromptAndGetDateTime(string prompt)
        {
            DateTime input;
            bool status;
            do
            {
                status = DateTime.TryParse(PromptAndGetNonEmptyString(prompt), out input);

                if (!status)
                    Console.WriteLine("Format is wrong!");

            } while (!status);

            return input;
        }


        public static Exam PromptAndGetExamResult()
        {
            var student = PromptAndGetStudent();
            var point = PromptAndGetPositiveDouble("Point: ");
            var subject = PromptAndGetNonEmptyString("Subject: ");
            var startDate = PromptAndGetDateTime("Start Date: ");
            var endDate = PromptAndGetDateTime("End Date: ");

            return new(student,point,subject,startDate,endDate);
        }

        public static Student PromptAndGetStudent()
        {
            Console.WriteLine("Student:");
            var name = PromptAndGetNonEmptyString("Name: ");
            var surName = PromptAndGetNonEmptyString("Surname: ");

            return new(name,surName);
        }

    }
}
