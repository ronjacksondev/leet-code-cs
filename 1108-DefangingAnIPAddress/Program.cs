using System;

namespace _1108_DefangingAnIPAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            string solution1 = new Solution().DefangIPaddr("1.1.1.1");
            Console.WriteLine(string.Join(",", solution1));

            string solution2 = new Solution().DefangIPaddr("255.200.50.0");
            Console.WriteLine(string.Join(",", solution2));
        }
    }

    public class Solution
    {
        public string DefangIPaddr(string address)
        {
            string defangedIP = "";
            foreach (char character in address)
            {
                if(character == '.')
                {
                    defangedIP += "[.]";
                }
                else
                {
                    defangedIP += character;
                }
            }
            return defangedIP;
        }
    }

    /*
     * Convert string to array of characters
     * create new string while looping through
     * if the character is a dot then add [ before and add ] after
     */
}
