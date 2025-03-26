using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace leet_code_cs
{
    [TestClass]
    public sealed class LC_0009_PalindromeNumber
    {

        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int x = 121;
            string y = x.ToString();

            // Act
            bool isPalindrome = IsPalindrome(x);
            bool isPalindromeString = IsPalindrome(y);

            // Assert
            Assert.AreEqual(isPalindrome, true);
            Assert.AreEqual(isPalindromeString, true);
        }


        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            int x = -121;
            string y = x.ToString();

            // Act
            bool isPalindrome = IsPalindrome(x);
            bool isPalindromeString = IsPalindrome(y);

            // Assert
            Assert.AreEqual(isPalindrome, false);
            Assert.AreEqual(isPalindromeString, false);
        }


        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            int x = 10;
            string y = x.ToString();

            // Act
            bool isPalindrome = IsPalindrome(x);
            bool isPalindromeString = IsPalindrome(y);

            // Assert
            Assert.AreEqual(isPalindrome, false);
            Assert.AreEqual(isPalindromeString, false);
        }


        [TestMethod]
        public void TestMethod4()
        {
            // Arrange
            int x = 1001;
            string y = x.ToString();

            // Act
            bool isPalindrome = IsPalindrome(x);
            bool isPalindromeString = IsPalindrome(y);

            // Assert
            Assert.AreEqual(isPalindrome, true);
            Assert.AreEqual(isPalindromeString, true);
        }

        [TestMethod]
        public void TestMethod5()
        {
            // Arrange
            int x = 1000021;
            string y = x.ToString();

            // Act
            bool isPalindrome = IsPalindrome(x);
            bool isPalindromeString = IsPalindrome(y);

            // Assert
            Assert.AreEqual(isPalindrome, false);
            Assert.AreEqual(isPalindromeString, false);
        }

        [TestMethod]
        public void TestMethod6()
        {
            // Arrange
            int x = 12345678;
            string y = x.ToString();

            // Act
            bool isPalindrome = IsPalindrome(x);
            bool isPalindromeString = IsPalindrome(y);

            // Assert
            Assert.AreEqual(isPalindrome, false);
            Assert.AreEqual(isPalindromeString, false);
        }


        /* Whiteboard
         * Option 1 convert to a string
         * Check if first index equals last index
         *   If yes
         *     Check if first index number +1 is less then current last index number
         *       If yes
         *         perform index check listed above again
         *       If no 
         *         return true
         *   If no
         *     return false
         *     
         * Option 2 compare integers
         * Number range is 2,147,483,648
         * If it is negative return false
         * If it is positive
         *   Have upper limit
         *   1 billion
         *   Have lower limit
         *   10
         *   Loop While upper limit is > lower limit
         *   If x >= upperlimit
         *     Then check
         *       if x / upper limit != x / lower limit
         *         return false
         *       upperlimit / 10
         *       lowerlimit * 10
         *   Loop a comparison starting at 999,999,999 and decreasing by 10
         *      IF x > placeholder
         *   
         */

        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            int lowerLimit = 1;
            int upperLimit = 1000000000;
            while(upperLimit > lowerLimit)
            {
                Debug.WriteLine(lowerLimit);
                Debug.WriteLine(upperLimit);
                Debug.WriteLine(x);
                Debug.WriteLine("");
                int upperPortion = x / upperLimit;
                if( upperPortion > 0)
                {
                    Debug.WriteLine("UpperPortionGreaterThanZero");
                    int upperDigit = upperPortion % 10;
                    Debug.WriteLine(upperDigit.ToString(), "Upper Digit");
                    int lowerDigit = (x / lowerLimit) % 10;
                    Debug.WriteLine(lowerDigit.ToString(), "Lower Digit");
                    Debug.WriteLine("");

                    if (lowerDigit != upperDigit)
                    {
                        return false;
                    }
                    lowerLimit *= 10;
                }
                upperLimit /= 10;
            }
            return true;
        }

        public bool IsPalindrome(string y)
        {
            int firstIndex = 0;
            int lastIndex = y.Length - 1;
            do
            {
                if (y[firstIndex] != y[lastIndex])
                {
                    return false;
                }
                firstIndex++;
                lastIndex--;
            }
            while (firstIndex < lastIndex);
            return true;
        }
    }
}
