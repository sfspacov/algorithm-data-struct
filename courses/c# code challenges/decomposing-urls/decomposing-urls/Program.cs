foreach (var item in DecomposingUrls("www.google.com/maps"))
{
    Console.Write(item + " ");
}
Console.WriteLine();
Console.WriteLine();
foreach (var item in DecomposingUrls("www.google.com/todo-list"))
{
    Console.Write(item + " ");
}
Console.WriteLine();

string[] DecomposingUrls(string url)
{
    url = url.Replace("www.", "").Replace("-", " ");
    var urlSplitted = url.Split("/");
    return urlSplitted;
}