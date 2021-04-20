using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book
            {
                Name = "Grade Boo"
            };
            
            book.AddGrade(89.54);
            book.AddGrade(56.8);
            book.AddGrade(32.23);

            var statistic = book.GetStatistic();
            Console.WriteLine($"the low is {statistic.Low}");
            Console.WriteLine($"the high is {statistic.High}");
            Console.WriteLine($"the average is {statistic.Average:N}");
        }
    }
}
