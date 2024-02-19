using Microsoft.VisualStudio.TestTools.UnitTesting;
using A1_ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_ConsoleApp.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void ConsoleMenuTest()
        {
            // Arrange
            Assert.Fail();
        }

        [TestMethod()]
        public void PrintRandomNumberTest() 
        {
            // Arrange
            var originalConsoleOut = Console.Out; // Save the original Console.Out
            var outputBuilder = new StringWriter();
            Console.SetOut(outputBuilder); // Redirect Console.Out

            // Act
            Program.PrintRandomNumber();

            // Assert
            string expectedOutputStart = "Printing random number. Intense computation incoming!";
            string actualOutput = outputBuilder.ToString();
            Assert.IsTrue(actualOutput.StartsWith(expectedOutputStart));
            Assert.IsTrue(actualOutput.Contains("Random number:"));

            // Restore the original Console.Out
            Console.SetOut(originalConsoleOut);
        }

        [TestMethod()]
        public void PrintTodaysDateTest() 
        {
            // Arrange
            var originalConsoleOut = Console.Out; // Save the original Console.Out
            var outputBuilder = new StringWriter();
            Console.SetOut(outputBuilder); // Redirect Console.Out
            string today = DateTime.Now.ToShortDateString();

            // Act
            Program.PrintTodaysDate();

            // Assert
            string expectedOutputStart = "Todays date is: ";
            string actualOutput = outputBuilder.ToString();
            Assert.IsTrue(actualOutput.StartsWith(expectedOutputStart));
            Assert.IsTrue(actualOutput.Contains(today));

            // Restore the original Console.Out
            Console.SetOut(originalConsoleOut);
        }

        [TestMethod()]
        public void PrintRandomDinoTest() { }

        [TestMethod()]
        public void PrintRandomStringActionTest() { }


    }
}