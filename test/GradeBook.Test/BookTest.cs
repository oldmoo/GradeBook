using System;
using Xunit;

namespace GradeBook.Test
{
    public class BookTest
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //  arrange
            var book = new Book
            {
                Name = "Book 1"
            };
            book.AddGrade(89.54);
            book.AddGrade(56.8);
            book.AddGrade(32.23);
            // act
            var result = book.GetStatistic();
            // assert
            Assert.Equal(89.54,result.High);
            Assert.Equal(32.23,result.Low);
        }
    }
}
