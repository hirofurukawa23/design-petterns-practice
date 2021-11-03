using Microsoft.Extensions.Primitives;
using System.Collections.Generic;

namespace Interpreter_pattern
{
    public class Context
    {
        private int number;
        private StringTokenizer.Enumerator tokenizer;
        private StringSegment currentToken;
        public Context(string text)
        {
            tokenizer = new StringTokenizer(text, new char[] { ' ' }).GetEnumerator();
            NextToken();
        }

        public void SkipToken(string token)
        {
            if (!currentToken.Value.Equals(token))
            {
                throw new System.Exception($"{token} is expected, but {currentToken} is found.");
            }
            NextToken();
        }

        public string NextToken()
        {
            if (tokenizer.MoveNext())
            {
                currentToken = tokenizer.Current;
            }
            else
            {
                currentToken = null;
            }
            number++;
            return currentToken.ToString();
        }

        public string CurrentToken()
        {
            return currentToken.ToString();
        }

        public int CurrentNumber()
        {
            return number;
        }
    }
}
