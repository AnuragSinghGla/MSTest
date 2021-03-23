using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestMSExercise45
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CalcLib.Calculation objc = new CalcLib.Calculation();
            double num1 = 64;
            double squareRes = num1*num1;
            double squarerootRes = Math.Sqrt(num1);
            double cubeRes = num1 * num1*num1;

            Assert.AreEqual(squareRes, objc.Square(num1));
            Assert.AreEqual(squarerootRes, objc.SquareRoot(num1));
            Assert.AreEqual(cubeRes, objc.Cube(num1));

        }
    }
}
