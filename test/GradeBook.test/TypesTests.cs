using System;
using Xunit;

namespace GradeBook.test
{
    public class Typetest
    {
        [Fact]
        public void test0()
        {
            //arrange
            var book1 = GetBook("Book1");
            var book2 = GetBook("Book2");
            

            Assert.Equal("Book1", book1.Name);
            Assert.Equal("Book2", book2.Name);
        }

        [Fact]
        public void test1()
        {
            //arrange
            var book1 = GetBook("Book1");
            var book2 = GetBook("Book2");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
            Assert.Equal("Book2", book2.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void test2()
        {
            //arrange
            var book1 = GetBook("Book1");
            var book2 = book1;

            Assert.Equal("Book1", book2.Name);
        }
        Book GetBook(string name)
        {
          return new Book(name);
        }
    }
}
