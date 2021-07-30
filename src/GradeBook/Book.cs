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
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Enter valid number");
            }
        }
        public Statistic GetStatistic()
        {
            var result = new Statistic();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            var i = 0;
            do
            {
                result.High = Math.Max(grades[i], result.High);
                result.Low = Math.Min(grades[i], result.Low);
                result.Average += grades[i];
                i++;
            }while(i < grades.Count);
        
            result.Average = result.Average / grades.Count;
            switch (result.Average)
            {
                case var d when d >= 90:
                result.Letter ='A';
                break;

                case var d when d >= 80:
                    result.Letter = 'B';
                    break;

                case var d when d >= 70:
                    result.Letter = 'C';
                    break;

                case var d when d >= 60:
                    result.Letter = 'D';
                    break;

                default:
                    result.Letter = 'F';
                    break;

            }
            return result;
        }

        
        private List<double> grades;
        public string Name;
    }
}