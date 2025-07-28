using System;
using System.Collections.Generic;
using System.Linq;

namespace ParenthesesBalanceLibrary.ParenthesesChecker;

public static class ParenthesesChecker
{
    public static bool IsParenthesesBalanced(string input) {
        //Check if input is valid
        if (string.IsNullOrEmpty(input)) {
            return true;//An empty string is balanced
        }

        //Map out valid parentheses combinations using a data structure
        Dictionary<char, char> brackets = new Dictionary<char, char>()
        {
            {')', '('},
            {'}', '{'},
            {'>', '<'},
            {']', '['},
            {'"', '"'}
        };

        //Create a stack to hold open bracket characters in order
        Stack<char> orderedStack = new Stack<char>();

        //Loop through the input
        foreach (char c in input) {
            //Select opening brackets and add to a stack
            if (brackets.ContainsValue(c))orderedStack.Push(c);

            //On encountering the first closing brace compare to the last item on the stack(Peek())
            else if (brackets.ContainsKey(c)) 
            {
                //If Peep != closing brace return FALSE
                if (orderedStack.Count == 0 || orderedStack.Peek() != brackets[c])
                {
                    return false;
                }
                else
                    //Else Pop the stack and repeat
                    orderedStack.Pop();
            }
        }
        return orderedStack.Count == 0;
    }
}

