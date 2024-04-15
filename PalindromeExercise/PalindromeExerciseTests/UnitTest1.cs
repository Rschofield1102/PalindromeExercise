using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("kayak", true)]
        [InlineData("kayaks", false)]// ← you will need to put some test data and expected result here.  
        public void IsAPalindrome(string x, bool expected)
        {

            //AAA
            var test = new WordSmith();

            var actual = test.IsAPalindrome(x);
            Assert.Equal(expected,actual);


        }
        // For example [InlineData(“racecar”, true)]  


        public void Test1()
        {

        }
    }
}
