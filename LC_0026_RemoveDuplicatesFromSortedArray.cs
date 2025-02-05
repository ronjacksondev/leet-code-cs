using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_code_cs
{
    [TestClass]
    public sealed class LC_0026_RemoveDuplicatesFromSortedArray
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int[] nums1 = { 1, 1, 2 };
            int[] expectedNums1 = { 1, 2 };

            // Act
            int k1 = removeDuplicates(nums1);
            Debug.WriteLine(k1, "k1");

            // Assert
            Assert.AreEqual(expectedNums1.Length, k1);
            for(int i = 0; i < k1; i++)
            {
                Assert.AreEqual(expectedNums1[i], nums1[i]);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            int[] nums2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int[] expectedNums2 = { 0, 1, 2, 3, 4 };

            // Act
            int k2 = removeDuplicates(nums2);

            // Assert
            Assert.AreEqual(expectedNums2.Length, k2);
            for (int i = 0; i < k2; i++)
            {
                Assert.AreEqual(expectedNums2[i], nums2[i]);
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            int[] nums3 = { 1, 1, 1, 2, 2, 2, 3, 3, 3 };
            int[] expectedNums3 = { 1, 2, 3 };

            // Act
            int k3 = removeDuplicates(nums3);

            // Assert
            Assert.AreEqual(expectedNums3.Length, k3);
            for (int i = 0; i < k3; i++)
            {
                Assert.AreEqual(expectedNums3[i], nums3[i]);
            }
        }

        /* Whiteboard
         * Set pointer variable to start with 0
         * Loop elements by index
         *   Get element at index mainPointer
         *   Get element at increment index (i)
         *   Is i > mainPointer
         *     If yes
         *         set mainPointer ++
         *         set array[pointer] = array[i]
         *     If no then continue (i++)
         * Return pointer++
         */

        private int removeDuplicates(int[] nums)
        {
            int pointer = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[pointer])
                {
                    pointer++;
                    nums[pointer] = nums[i];
                }
            }
            return ++pointer;
        }

    }
}
