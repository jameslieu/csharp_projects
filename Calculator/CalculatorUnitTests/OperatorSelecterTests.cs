using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTests
{
    [TestClass]
    public class OperatorSelecterTests
    {
        [TestMethod]
        public void Test_PlusOperator()
        {
            string expected = "2";
            string result = Calculator.OperatorSelector.HandleEquation("+", 1, "1");

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_MinusOperator()
        {
            string expected = "2";
            string result = Calculator.OperatorSelector.HandleEquation("-", 3, "1");

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_TimesOperator()
        {
            string expected = "10";
            string result = Calculator.OperatorSelector.HandleEquation("*", 5, "2");

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_DivideOperator()
        {
            string expected = "10";
            string result = Calculator.OperatorSelector.HandleEquation("/", 20, "2");

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_DivideOperatorCannotDivideByZero()
        {
            string expected = "";
            string result = Calculator.OperatorSelector.HandleEquation("/", 20, "0");

            Assert.AreEqual(expected, result);
        }
    }
}
