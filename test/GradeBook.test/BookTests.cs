using System;
using Xunit;

namespace GradeBook.test
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAverageGrade()
        {
            //arrange
            var book = new Book("");
            book.GradeBook(89.1);
            book.GradeBook(71.1);
            book.GradeBook(77.1);
            //act
            var result = book.GetStatistic();
            //assert
            Assert.Equal(79.1, result.Average);
            Assert.Equal(71.1, result.Low);
            Assert.Equal(89.1, result.High);
            Assert.Equal('C', result.Letter);

        }
    
    }
}
