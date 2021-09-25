using System;
using Xunit;

namespace BadSuperbowlNamer.Tests
{
    // Test classes must be public

    public class NumberToRomanNumberalTests
    {
        // [Fact] tells xunit this is a test - [Fact] single piece 
        // Must have fact attribute and needs to be public
        // Nobody calls test method, so name can be long and descriptive.
        [Fact]
        public void the_number_1_is_translated_into_the_letter_I()
        {
            // Arrange -> context where the test is run
            var numberToTranslate = 1;
            var expectedResult = "I";
            var translator = new NumberTranslator();

            // Act -> the actual thing we are testing
            string actualResult = translator.Translate(numberToTranslate);


            // Assert -> lay out the expectations in such a way that it not met, exceptions are thrown.
            /*
            if (actualResult != expectedResult)
            {
                throw new Exception($"This is wrong. {actualResult} is not equal to {expectedResult}");
            }
            */

            // Assertion library - same as above code
            Assert.Equal(expectedResult, actualResult);


            // Tests pass if no exceptions are thrown while the test is running.
            // Tests fail if any exceptions are thrown while the test is running.

        }

        [Fact]
        public void the_number_4_is_translated_to_IV()
        {
            // Arrange
            var numberToTranslate = 4;
            var expectedResult = "IV";
            var translator = new NumberTranslator();

            // Act
            string actualResult = translator.Translate(numberToTranslate);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
        
        [Fact]
        public void the_number_3_is_translated_to_IV()
        {
            // Arrange
            var numberToTranslate = 3;
            var expectedResult = "III";
            var translator = new NumberTranslator();

            // Act
            string actualResult = translator.Translate(numberToTranslate);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(3549, "MMMDXLIX")]
        [InlineData(1, "I")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        public void translate_to_roman_theory(int numberToTranslate, string expectedResult)
        {
            // Arrange
            var translator = new NumberTranslator();

            // Act
            string actualResult = translator.Translate(numberToTranslate);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
        [Theory]
        [InlineData(3549, 1000)]
        [InlineData(1001, 1000)]
        [InlineData(1000, 1000)]
        [InlineData(901, 900)]
        [InlineData(900, 900)]
        [InlineData(51, 50)]
        [InlineData(50, 50)]
        [InlineData(41, 40)]
        public void get_base_value(int number, int expectedResult)
        {
            // Arrange
            var translator = new NumberTranslator();

            // Act
            int actualResult = translator.GetBaseValue(number);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(1000, "M")]
        [InlineData(900, "CM")]
        [InlineData(500, "D")]
        [InlineData(400, "CD")]
        [InlineData(100, "C")]
        [InlineData(90, "XC")]
        [InlineData(50, "L")]
        [InlineData(40, "XL")]
        [InlineData(10, "X")]
        [InlineData(9, "IX")]
        [InlineData(5, "V")]
        [InlineData(4, "IV")]
        [InlineData(1, "I")]
        public void get_symbo(int number, string expectedResult)
        {
            // Arrange
            var translator = new NumberTranslator();

            // Act
            string actualResult = translator.GetSymbol(number);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
