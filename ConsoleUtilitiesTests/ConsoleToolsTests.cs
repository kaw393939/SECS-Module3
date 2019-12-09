using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleUtilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace ConsoleUtilities.Tests
{
    [TestClass()]
    public class ConsoleToolsTests
    {
        //Arrange
        private readonly ConsoleTools consoleTools = new ConsoleTools();
        private readonly StringWriter Sw = new StringWriter();

        [TestInitialize()]
        public void SetOut()
        {
            Console.SetOut(Sw);
        }

        [TestCleanup]
        public void CleanUp()
        {
            StreamWriter standardOut =
                new StreamWriter(Console.OpenStandardOutput())
                {
                    AutoFlush = true
                };
            Console.SetOut(standardOut);
        }

        [TestMethod()]
        public void WriteStringTest()
        {
            //Arrange
            string expected = "Hello World";
            //Act
            consoleTools.Write(expected);
            //Assert
            Assert.AreEqual(expected, Sw.ToString().Trim());

        }

        [TestMethod()]
        public void WriteArrayTest()
        {
            string[] inputArray = { "Hello World", "Steve", "Joe" };

            consoleTools.Write(inputArray);
            string expected = "Hello World Steve Joe";
            Assert.AreEqual(expected, Sw.ToString().Trim());
        }

        [TestMethod()]
        public void ReadLineTest()
        {
            //Arranging Test
            string consoleInput = "Steve";
            StringReader sr = new StringReader(consoleInput);
            //Setting Console Input to the String Reader
            Console.SetIn(sr);
            //Read the results of the what is input to the console through the string reader.
            string result = consoleTools.Read();
            Assert.AreEqual(result, consoleInput);
        }
    }
}