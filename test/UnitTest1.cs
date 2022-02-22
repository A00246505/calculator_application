using Microsoft.VisualStudio.TestTools.UnitTesting;

using calculator_library;
using System;

namespace test
{
    [TestClass]
    public class CalculatorTest
    {
        Calculator _calc;

        public CalculatorTest()
        {
            _calc = new Calculator();
        }

        [TestMethod]
        public void should_add_two_numbers()
        {
            double result = _calc.addition(3, 5);
            Assert.AreEqual(result, 8);

            result = _calc.addition(-5, 3);
            Assert.AreEqual(result, -2);

            result = _calc.addition(4, 2);
            Assert.AreEqual(result, 6);

            result = _calc.addition(80, 100);
            Assert.AreEqual(result, 180);

            result = _calc.addition(-20, -10);
            Assert.AreEqual(result, -30);

            result = _calc.addition(50, 20);
            Assert.AreEqual(result, 70);

            result = _calc.addition(99, 1);
            Assert.AreEqual(result, 100);

            result = _calc.addition(89, 3);
            Assert.AreEqual(result, 92);

            result = _calc.addition(100, 90);
            Assert.AreEqual(result, 190);

            result = _calc.addition(50000, 44);
            Assert.AreEqual(result, 50044);
        }

        [TestMethod]
        public void should_subtract_two_numbers()
        {
            double result = _calc.subtraction(3, 5);
            Assert.AreEqual(result, -2);

            result = _calc.subtraction(-5, 3);
            Assert.AreEqual(result, -8);

            result = _calc.subtraction(4, 2);
            Assert.AreEqual(result, 2);

            result = _calc.subtraction(80, 100);
            Assert.AreEqual(result, -20);

            result = _calc.subtraction(-20, -10);
            Assert.AreEqual(result, -10);

            result = _calc.subtraction(50, 20);
            Assert.AreEqual(result, 30);

            result = _calc.subtraction(99, 1);
            Assert.AreEqual(result, 98);

            result = _calc.subtraction(89, 3);
            Assert.AreEqual(result, 86);

            result = _calc.subtraction(100, 90);
            Assert.AreEqual(result, 10);

            result = _calc.subtraction(50000, 44);
            Assert.AreEqual(result, 49956);
        }

        [TestMethod]
        public void should_multiply_two_numbers()
        {
            double result = _calc.multiplication(3, 5);
            Assert.AreEqual(result, 15);

            result = _calc.multiplication(-5, 3);
            Assert.AreEqual(result, -15);

            result = _calc.multiplication(4, 2);
            Assert.AreEqual(result, 8);

            result = _calc.multiplication(80, 100);
            Assert.AreEqual(result, 8000);

            result = _calc.multiplication(-20, -10);
            Assert.AreEqual(result, 200);

            result = _calc.multiplication(50, 20);
            Assert.AreEqual(result, 1000);

            result = _calc.multiplication(99, 1);
            Assert.AreEqual(result, 99);

            result = _calc.multiplication(89, 3);
            Assert.AreEqual(result, 267);

            result = _calc.multiplication(100, 90);
            Assert.AreEqual(result, 9000);

            result = _calc.multiplication(50000, 44);
            Assert.AreEqual(result, 2200000);
        }

        [TestMethod]
        public void should_divide_two_numbers()
        {
            double result = _calc.division(3, 5);
            Assert.AreEqual(result, 0.6);

            result = _calc.division(-5, 2);
            Assert.AreEqual(result, -2.5);

            result = _calc.division(4, 2);
            Assert.AreEqual(result, 2);

            result = _calc.division(80, 100);
            Assert.AreEqual(result, 0.8);

            result = _calc.division(-20, -10);
            Assert.AreEqual(result, 2);

            result = _calc.division(50, 20);
            Assert.AreEqual(result, 2.5);

            result = _calc.division(99, 1);
            Assert.AreEqual(result, 99);

            result = _calc.division(84, 4);
            Assert.AreEqual(result, 21);

            result = _calc.division(100, 50);
            Assert.AreEqual(result, 2);
        }
    }


}
