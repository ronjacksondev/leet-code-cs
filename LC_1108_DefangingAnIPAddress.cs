using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_code_cs
{
    [TestClass]
    public sealed class LC_1108_DefangingAnIPAddress
    {

        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string input = "1.1.1.1";
            string expectedOutput = "1[.]1[.]1[.]1";

            // Act
            string actualOutput = DefangIPaddr(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }


        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            string input = "255.100.50.0";
            string expectedOutput = "255[.]100[.]50[.]0";

            // Act
            string actualOutput = DefangIPaddr(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        /* Whiteboard
         * Find the first instance of dot and replace it with parens dot
         * Do again 3 more times
         * 
         */

        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }

    }
}
