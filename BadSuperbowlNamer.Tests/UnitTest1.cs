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
    }
}
