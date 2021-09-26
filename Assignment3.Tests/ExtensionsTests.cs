using System;
using Xunit;

namespace BDSA2020.Assignment03.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void Test1()
        {

        }
        [Fact]
        public void IsSecure_returns_false_with_unsecure_uri()
        {
            var url = new Uri("http://itu.dk");
            Assert.False(url.IsSecure());        
        }

        [Fact]
        public void IsSecure_returns_true_with_secure_uri()
        {
            var url = new Uri("https://itu.dk"); 
            Assert.True(url.IsSecure()); 
        }

        [Theory]
        [InlineData("Hello World!", 1)] //<--- "World!" should have been a word, but isn't according to the specification (talk to Paolo about ambiguity in requirements)
        [InlineData("this is a test", 4)]
        [InlineData("1this 1is 1a 1test", 0)]
        [InlineData("and æ ø og å", 5)]
        [InlineData("You're a wizard Harry", 3)] //<--- You're should have been a word, but isn't according to the specification (talk to Paolo about ambiguity in requirements) 
        public void WordCount_returns_correct_amount_of_words(string input, int expectedNumWords) 
        {
            Assert.Equal(expectedNumWords, input.WordCount()); 
        } 
    }
}
