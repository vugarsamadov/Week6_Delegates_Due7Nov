using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTask.Models
{
    internal class Exam
    {

        public Student Student { get; init; }
        public double Point { get; init; }
        public string Subject { get; init; }
        public DateTime StartDate{ get; init; }
        public DateTime EndDate { get; init; }

        public double Duration { get => (EndDate - StartDate).TotalHours; }
        
        public Exam(Student student, double point, string subject, DateTime startDate, DateTime endDate)
        {
            Student = student;
            Point = point;
            Subject = subject;
            StartDate = startDate;
            EndDate = endDate;
        }

        public override string ToString()
        {
            return $"{Student.Name} {Subject} {Point} ";
        }

    }
}
