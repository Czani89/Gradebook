using System;
using Xunit;

namespace GradeBook.test
{
    public class Typetest
    {
      
        [Fact]
        public void test3()
        {
            //arrange
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }
        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            //arrange
            string name = "Scott";
            MakeUppercase(name);

            var UpperName = MakeUppercase(name);

            Assert.Equal("Scott", name);
            Assert.Equal("SCOTT", UpperName);

        }
        private string MakeUppercase(string parameter)
        {
           return parameter.ToUpper();
        }

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
        public void CSharpcanPassByRef()
        {
            //arrange
            var book1 = GetBook("Book1");
            var book2 = GetBook("Book2");
            GetNameSetName(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);
            Assert.Equal("Book2", book2.Name);
        }

        private void GetNameSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpPassByValue()
        {
            //arrange
            var book1 = GetBook("Book1");
            var book2 = GetBook("Book2");
            GetNameSetName(book1, "New Name");

            Assert.Equal("Book1", book1.Name);
            Assert.Equal("Book2", book2.Name);
        }

        private void GetNameSetName(Book book, string name)
        {
            book = new Book(name);
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
