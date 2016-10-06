using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetFizzBuzzWithNegativeMultipleOf3()
        {
            var fizzBuzz = new FizzBuzz();
            var returnValue = fizzBuzz.GetFizzBuzz("-3");
            Assert.IsTrue(returnValue == "Fizz");
        }

        [TestMethod]
        public void TestGetFizzBuzzWithNegativeNonMultipleNumber()
        {
            var fizzBuzz = new FizzBuzz();
            var returnValue = fizzBuzz.GetFizzBuzz("-1");
            Assert.IsTrue(returnValue == "-1");
        }

        [TestMethod]
        public void TestGetFizzBuzzWithPositiveMultipleOf3()
        {
            var fizzBuzz = new FizzBuzz();
            var returnValue = fizzBuzz.GetFizzBuzz("9");
            Assert.IsTrue(returnValue == "Fizz");
        }

        [TestMethod]
        public void TestGetFizzBuzzWithPositiveMultipleOf5()
        {
            var fizzBuzz = new FizzBuzz();
            var returnValue = fizzBuzz.GetFizzBuzz("25");
            Assert.IsTrue(returnValue == "Buzz");
        }

        [TestMethod]
        public void TestGetFizzBuzzWithPositiveMultipleOf5And3()
        {
            var fizzBuzz = new FizzBuzz();
            var returnValue = fizzBuzz.GetFizzBuzz("30");
            Assert.IsTrue(returnValue == "Fizzbuzz");
        }

        [TestMethod]
        public void TestGetFizzBuzzWithPositiveNonMultipleNumber()
        {
            var fizzBuzz = new FizzBuzz();
            var returnValue = fizzBuzz.GetFizzBuzz("101");
            Assert.IsTrue(returnValue == "101");
        }

        [TestMethod]
        public void TestGetFizzBuzzWith0()
        {
            var fizzBuzz = new FizzBuzz();
            var returnValue = fizzBuzz.GetFizzBuzz("0");
            Assert.IsTrue(returnValue == "Fizzbuzz");
        }

        [TestMethod]
        public void TestGetFizzBuzzWithVeryBigInteger()
        {
            var fizzBuzz = new FizzBuzz();
            var returnValue = fizzBuzz.GetFizzBuzz("12387248728472389748932748732134");
            Assert.IsTrue(returnValue == "Please enter a valid integer number (Int32)");
        }

        [TestMethod]
        public void TestGetFizzBuzzWithOutInteger()
        {
            var fizzBuzz = new FizzBuzz();
            var returnValue = fizzBuzz.GetFizzBuzz("Test");
            Assert.IsTrue(returnValue == "Please enter a valid integer number (Int32)");
        }
    }
}
