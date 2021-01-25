using System.Collections;

namespace algorithm
{
    public static class StackProblem
    {
        static Stack stack = new Stack();

        /// <summary>
        /// Input: exp = “[()]{}{[()()]()}” 
        //  Output: Balanced

        // Input: exp = “[(])” 
        // Output: Not Balanced
        /// </summary>
        public static bool IsBalanced(string input)
        {
            stack.Clear();

            var brackets = input.ToCharArray();

            if (IsClosedBracket(brackets[0]))
                return false;

            foreach (char bracket in brackets)
            {
                if(IsClosedBracket(bracket))
                {
                    var lastElement = (char)stack.Pop();
                    if (!AreCorrectPairs(bracket, lastElement))
                        return false;// stack.Push(bracket);
                }
                else
                    stack.Push(bracket);

            }

            if (stack.Count == 0)
                return true;
            else
                return false;
        }

        private static bool IsClosedBracket(char bracket)
        {
            if (bracket == ')' || bracket == ']' || bracket == '}')
                return true;
            else
                return false;
        }

        private static bool AreCorrectPairs(char closeBracket, char lastBracket)
        {
            if (closeBracket == ')' && lastBracket == '(')
                return true;
            else if (closeBracket == ']' && lastBracket == '[')
                return true;
            else if (closeBracket == '}' && lastBracket == '{')
                return true;
            else
                return false;
        }
    }
}
