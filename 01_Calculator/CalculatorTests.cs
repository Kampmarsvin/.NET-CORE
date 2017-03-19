
using Xunit;

namespace _01_Calculator
{
    public class CalculatorTests
    {
        [Fact]
        public void Add()
        {
            Assert.Equal(0, Calculator.Add(0, 0));
            Assert.Equal(4, Calculator.Add(2, 2));
            Assert.Equal(8, Calculator.Add(2, 6));
        }
        /*[Fact]
        public void Subtract()
        {
            Assert.Equal(6, Calculator.Subtract(10, 4));
        }
        [Fact]
        public void Sum()
        {
            //Arrange
            int[] numbers = new int[2];
            Assert.Equal(0, Calculator.Sum(numbers));

            numbers[0] = 7;
            Assert.Equal(7, Calculator.Sum(numbers));

            numbers[0] = 7;
            numbers[1] = 11;
            Assert.Equal(18, Calculator.Sum(numbers));

        }
        [Fact]
        public void Multiply()
        {
            //It multiplies two numbers
            //It multiplies several numbers
            throw new NotImplementedException();
        }
        [Fact]
        public void Power()
        {
            //It raises one number to the power of another number
            throw new NotImplementedException();
        }
        [Fact]
        public void Factorial()
        {
            //# http://en.wikipedia.org/wiki/Factorial
            //  it "computes the factorial of 0"
            //  it "computes the factorial of 1"
            //  it "computes the factorial of 2"
            //  it "computes the factorial of 5"
            //  it "computes the factorial of 10"
            throw new NotImplementedException();
        }*/
    }
}
