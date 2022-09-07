Console.WriteLine(IsBalanced("{}"));
Console.WriteLine(IsBalanced("({[}[}])"));
Console.WriteLine(IsBalanced("[(])"));
Console.WriteLine(IsBalanced("{()[[[[[[[]]]]]]]]{}}"));
Console.WriteLine(IsBalanced("(([{({)}]))"));

const char L_PAREN = '(';
const char R_PAREN = ')';
const char L_BRACE = '{';
const char R_BRACE = '}';
const char L_BRACKET = '[';
const char R_BRACKET = ']';

bool IsBalanced(string input)
{
    var myStack = new Stack<char>();
    foreach (char c in input)
    {
        if (L_PAREN == c || L_BRACE == c || L_BRACKET == c)
        {
            myStack.Push(c);
        }
        else if (R_PAREN == c)
        {
            if (myStack.Peek() == L_PAREN)
            {
                myStack.Pop();
            }
            else
            {
                return false;
            }
        }

        else if (R_BRACE == c)
        {
            if (myStack.Peek() == L_BRACE)
            {
                myStack.Pop();
            }
            else
            {
                return false;
            }
        }
        else if (R_BRACKET == c)
        {
            if (myStack.Peek() == L_BRACKET)
            {
                myStack.Pop();
            }
            else
            {
                return false;
            }
        }
    }
    
    if (myStack.Any())
        return false;

    return true;
}