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
    }
}
