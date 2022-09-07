using System.Text.RegularExpressions;

string jsonString =
           @"{
              ""Name"": ""Weekly Comics Newsletter!"",
              ""Admin"": ""Jane Porter"",
              ""CreatedOn"": ""2022-01-01"",
              ""Subscribers"": [
                {
                  ""Name"": ""Jack Powell"",
                  ""ID"": 231,
                  ""Email"": ""jpowell0@hplussport.com""
                },
                {
                  ""Name"": ""Emily Garcia"",
                  ""ID"": 221
                },
                {
                  ""Name"": ""Richard Dean"",
                  ""ID"": 211
                },
                {
                  ""Name"": ""Jane Larson"",
                  ""ID"": 201,
                  ""Email"": ""jlarsone@hplussport.com""  
                }
              ]
            }";

// MARK: Result
var customerIDs = DecryptJSON(jsonString);
foreach (var id in customerIDs)
{
    Console.WriteLine($"\nSend missing info prompt to user ID: {id}");
}

static List<int> DecryptJSON(string json)
{
    var result = new List<int>();
    var jsonSplit = json.RemoveWhiteSpaces().Split("},{");
    foreach (var item in jsonSplit.Where(x => !x.Contains("Email") && !x.Contains("@")))
    {
        var value =item.Split("\"ID\":")[1].Replace("\"","");
        var id = Convert.ToInt32(value);
        result.Add(id);
    }

    return result;
}

Regex sWhitespace = new Regex(@"\s+");
public static class Extensions
{
    public static string RemoveWhiteSpaces(this string str) 
    {
        return Regex.Replace(str, @"\s+", String.Empty);
    }
}