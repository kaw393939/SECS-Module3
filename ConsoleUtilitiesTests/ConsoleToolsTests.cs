using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleUtilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUtilities.Tests
{
    [TestClass()]
    public class ConsoleToolsTests
    {
        [TestMethod()]
        public void WriteLineTest()
        {
            string expected = "Hello World";
            ConsoleTools consoleTools = new ConsoleTools();
            string result = consoleTools.WriteLine(expected);
            Assert.AreEqual(expected, result);

        }
    }
}