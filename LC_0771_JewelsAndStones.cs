using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_code_cs
{
    [TestClass]
    public sealed class LC_0771_JewelsAndStones
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string jewels = "aA";
            string stones = "aAAbbbb";

            // Act
            int solution = NumJewelsInStones(jewels, stones);

            // Assert
            Assert.AreEqual(3, solution);
        }


        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            string jewels = "z";
            string stones = "ZZ";

            // Act
            int solution = NumJewelsInStones(jewels, stones);

            // Assert
            Assert.AreEqual(0,solution);
        }

        /*
         * Loop through each of the stones
         *  Loop through each of the jewels and count if there are any matches
         *    If a stone is a jewel then increment the count
         */

        public int NumJewelsInStones(string jewels, string stones)
        {
            int count = 0;
            for (int i = 0; stones.Length > i; i++)
            {
                for (int j = 0; jewels.Length > j; j++)
                {
                    if (stones[i] == jewels[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
