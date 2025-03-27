using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace leet_code_cs
{
    [TestClass]
    public sealed class LC_1431_KidsWithGreatestNumberOfCandies
    {

        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int[] candies = [2, 3, 5, 1, 3];
            int extraCandies = 3;
            bool[] expectedOutput = [true, true, true, false, true];

            // Act
            IList<bool> actualResult = KidsWithCandies(candies, extraCandies);

            // Assert
            CollectionAssert.AreEqual(expectedOutput, actualResult.ToArray());
            
        }


        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            int[] candies = [4, 2, 1, 1, 2];
            int extraCandies = 1;
            bool[] expectedOutput = [true, false, false, false, false];

            // Act
            IList<bool> actualResult = KidsWithCandies(candies, extraCandies);

            // Assert
            CollectionAssert.AreEqual(expectedOutput, actualResult.ToArray());
        }


        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            int[] candies = [12, 1, 12];
            int extraCandies = 10;
            bool[] expectedOutput = [true, false, true];

            // Act
            IList<bool> actualResult = KidsWithCandies(candies, extraCandies);

            // Assert
            CollectionAssert.AreEqual(expectedOutput, actualResult.ToArray());
        }


        /* Whiteboard
         * First i would scan the array to see what the largest number is
         * Then i would check each item in the array to see if it was greater or equal to the highest number
         */

        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int greatestNumber = 0;
            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] > greatestNumber)
                {
                    greatestNumber = candies[i];
                }
            }
            Debug.WriteLine(greatestNumber);
            bool[] result = new bool[candies.Length];
            for (int i = 0; i < candies.Length; i++)
            {
                result[i] = (candies[i] + extraCandies >= greatestNumber);
            }
            Debug.WriteLine(string.Join(", ", result));
            return result;
        }

        public IList<bool> KidsWithCandies2(int[] candies, int extraCandies)
        {
            //AI version
            int greatestNumber = candies.Max(); // Find the maximum element
            var result = candies.Select(candy => candy + extraCandies >= greatestNumber).ToList();
            return result;
        }

    }
}
