using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator.Services;

namespace CalculatorTest
{
    public class StringValidationTest
    {
        private StringValidation _validation;

        public StringValidationTest()
        {
            _validation = new StringValidation();
        }

        [Fact]
        public void MustCount3CharsInOlaAndReturn3()
        {
            //Arrange
            string text = "Ola";

            //Act
            int result = _validation.CountChars(text);

            //Assert
            Assert.Equal(3, result);
        }
    }
}