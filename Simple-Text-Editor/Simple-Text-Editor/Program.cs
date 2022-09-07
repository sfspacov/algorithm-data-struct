using System.Text;

//args = new string[] { "8", "1 abc", "3 3", "2 3", "1 xy", "3 2", "4", "4", "3 1" };
args = new string[]
{"10","1 ewcgpjfh","1 igqsbqyp","1 qsdliigcj","4","3 15","1 iilmgp","2 8","4","2 18","1 scwhors"};

var stack = new Stack<string>();
var sb = new StringBuilder();

foreach (var item in args.Skip(1))
{
    var itemSplit = item.Split(' ');
    var command = Convert.ToInt16(itemSplit[0]);

    if (command == (int)Commands.Write)
    {
        var word = itemSplit[1];
        stack.Push($"{command} {word}");
        sb.Append(word);
    }
    else if (command == (int)Commands.Delete)
    {
        var index = Convert.ToInt16(itemSplit[1]);
        var word = new string(sb.ToString().Skip(sb.Length - index).ToArray());
        stack.Push($"{command} {word}");
        sb.Remove(sb.Length - index, index);
    }
    else if (command == (int)Commands.Print)
    {
        var index = Convert.ToInt16(itemSplit[1]);
        Console.WriteLine(sb.ToString()[index - 1]);
    }
    else if (command == (int)Commands.Undo)
    {
        if (stack.Any())
        {
            var itemSplit2 = stack.Pop().Split(' ');
            var command2 = Convert.ToInt16(itemSplit2[0]);

            if (command2 == (int)Commands.Write)
            {
                var index = itemSplit2[1].Count();
                sb.Remove(sb.Length - index, index);
            }
            else if (command2 == (int)Commands.Delete)
            {
                var word = itemSplit2[1];
                sb.Append(word);
            }
        }
    }
}
enum Commands
{
    Write = 1,
    Delete,
    Print,
    Undo
};