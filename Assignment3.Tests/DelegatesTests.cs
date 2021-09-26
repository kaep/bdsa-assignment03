using System;
using System.IO;
using Xunit;
using System.Linq;

namespace BDSA2020.Assignment03.Tests
{
    public class DelegatesTests
    {
        [Fact]
        public void Delegate_given_string_prints_characters_in_reverse()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Action<String> reversePrint = (s) => Console.WriteLine(s.Reverse().ToArray());

            reversePrint("Hello world");
            var output = writer.GetStringBuilder().ToString().Trim();
            
            Assert.Equal("dlrow olleH", output); 
        }

        [Theory]
        [InlineData(2, 5, 10)]
        [InlineData(2.5, 4, 10)]
        [InlineData(8, 16, 128)]
        public void Delegate_given_two_numbers_returns_product(float x, float y, float result)
        {
            Func<float, float, float> calcProduct = (x, y) => x*y;   
            Assert.Equal(result, calcProduct(x, y));
        }

        [Theory]
        [InlineData(42, " 0042")]
        [InlineData(42, "     42")]
        [InlineData(64, "64")]
        public void Delegate_given_integer_and_string_returns_numerical_equality_as_bool(int number, string text)
        {
            Func<int, string, bool> numericalEquality = (number, text) => Int32.Parse(text) == number; 

            Assert.True(numericalEquality(number, text)); 
        }
    }
}
