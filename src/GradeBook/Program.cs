using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Bob");
            book.GradeBook(89.1);
            book.GradeBook(79);
            book.GradeBook(63.5);
            book.GradeBook(55.55);

            var stats = book.GetStatistic();
            Console.WriteLine(stats.Average);
            Console.WriteLine(stats.Low);
            Console.WriteLine(stats.High);
          Console.WriteLine(stats.Letter);
        }
    }
}
