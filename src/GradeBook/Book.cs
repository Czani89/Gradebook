using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.Name = name;
        }
        public void GradeBook(double grade)
        {
            grades.Add(grade);
        }
        public Statistic GetStatistic()
        {
            var result = new Statistic();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach (var grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }
            result.Average = result.Average / grades.Count;
           return result;
        }
        private List<double> grades;
        public string Name;
    }
}