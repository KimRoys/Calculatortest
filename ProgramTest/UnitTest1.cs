using Calculatortest;
using System;
using Xunit;

namespace ProgramTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestSqrt()
        {
            double num1 = 9;
            double result = Math.Sqrt(num1);
            Assert.Equal(result, Program.Sqrroot(num1));
        }

        [Fact]
        public void TestPow()
        {
            double num = 4;
            double res = Math.Pow(num, 2);
            Assert.Equal(res, Program.Pow2(num));
        }

        [Fact]
        public void TestDivision()
        {
            double num1 = 220;
            double num2 = 4;
            double res = 55;
            Assert.Equal(res, Program.Division(num1, num2));
        }

        [Fact]
        public void TestDivisionDivideByZero()
        {
            double num1 = 220;
            double num2 = 0;
            double result = Program.Division(num1, num2);
            Assert.True(double.IsInfinity(result));
        }

        [Fact]
        public void TestMultiplication()
        {
            double num1 = 25;
            double num2 = 4;
            double result = 25*4;
            Assert.Equal(result, Program.Multiplication(num1, num2));
        }

        [Fact]
        public void TestAdd()
        {
            double num1 = double.NaN;
            double num2 = 20;
            double result = double.NaN;
            Assert.Equal(result, Program.Addition(num1, num2));
        }

        [Fact]

        public void TestSubtraction()
        {
            double num1 = 123;
            double num2 = 107;
            double result = 16;
            Assert.Equal(result, Program.Subtraction(num1, num2));
        }

        [Fact]
        public void TestSubtractionManyNumbers()
        {
            string nums = "200, 23, 53, 45";
            string[] arr = nums.Split();
            double result = 200 - 23 - 53 - 45;

            Assert.Equal(result, Program.Subtraction(arr));
        }

        [Fact]
        public void TestAdd1()
        {
            double num1 = 43;
            double num2 = 107;
            double result = 150;
            Assert.Equal(result, Program.Addition(num1, num2));
        }

        [Fact]
        public void TestAddManyNumbers()
        {
            string nums = "23, 53, 45";
            string[] arr = nums.Split();
            double result = 23 + 53 + 45;
            
            Assert.Equal(result, Program.Addition(arr));
        }
    }
}
