using System;

namespace _1678_GoalParserInterpretation
{
    class Program
    {
        static void Main(string[] args)
        {
            string solution1 = new Solution().Interpret("G()(al)");
            Console.WriteLine(string.Join(",", solution1));

            string solution2 = new Solution().Interpret("G()()()()(al)");
            Console.WriteLine(string.Join(",", solution2));

            string solution3 = new Solution().Interpret("(al)G(al)()()G");
            Console.WriteLine(string.Join(",", solution3));
        }
    }

    public class Solution
    {
        public string Interpret(string command)
        {
            char[] letters = command.ToCharArray();
            string interpretation = "";
            for (int i = 0; i < letters.Length; i++)
            {
                if(letters[i] == 'G')
                {
                    interpretation += "G";
                } 
                else if (letters[i] == '(' && letters[i+1] == ')')
                {
                    interpretation += "o";
                    i++;
                }
                else
                {
                    interpretation += "al";
                    i += 3;
                }
            }
            return interpretation;
        }
    }

    /* Whiteboard
     * loop through the letters
     * If it is G then return G and go to next index
     * If it is () then return 0 and advance +1 index
     * If it is (al) then return al and advance +3 index
     * */
}
