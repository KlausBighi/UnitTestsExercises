using Calculator.Services;

namespace calculatortest;

public class CalculatorTest
{

    private CalculatorImp _calc;

    public CalculatorTest()
    {
        _calc = new CalculatorImp();
    }

    [Fact]
    public void MustSum5And10AndReturn15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act
        int result = _calc.Sum(num1, num2);

        //Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void MustSum10And10AndReturn20()
    {
        //Arrange
        int num1 = 10;
        int num2 = 10;

        //Act
        int result = _calc.Sum(num1, num2);

        //Assert
        Assert.Equal(20, result);
    }

    [Fact]
    public void MustVerIf4IsPair()
    {
        //Arrange
        int num = 4;

        //Act
        bool result = _calc.IsPair(num);

        //Assert
        Assert.True(result);
    }

    /* Refact
    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)] */

    [Theory]
    [InlineData(new int[] { 2, 4, 6, 8, 10})]
    public void MustVerIfNumbersArePairAndReturnTrue(int[] num)
    {
        //Arrange

        //Act /Assert
        Assert.All(num, x => Assert.True(_calc.IsPair(x)));
    }
}