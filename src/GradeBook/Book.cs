using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GradeBook
{
    public class Book
    {
        public string Name { get; set; }
        private List<double> Grades { get; }

        public Book()
        {
            Grades = new List<double>();
        }
        public void AddGrade(double grade)
        {
            Grades.Add(grade);
        }

        public Statistics GetStatistic()
        {
            var statistic = new Statistics
            {
                Average = 0.0,
                Low = double.MaxValue,
                High = double.MinValue
            };

            foreach (var grade in Grades)
            {
                statistic.High = Math.Max(grade, statistic.High);
                statistic.Low = Math.Min(grade, statistic.Low);
            }

            statistic.Average /= Grades.Count;
            return statistic;
        }
    }
}