var n = 4;
var stack = new Stack<int>();
while (n > 0)
{
    var binary = n % 2;
    stack.Push(binary);
    n /= 2;
}
while (stack.Any())
    Console.Write(stack.Pop());