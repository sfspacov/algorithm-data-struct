Console.WriteLine(
    hourglassSum(new List<List<int>>
    {
        new List<int>{ 1,1,1,0,0,0},
        new List<int>{ 0,1,0,0,0,0},
        new List<int>{ 1,1,1,0,0,0},
        new List<int>{ 0,0,2,4,4,0},
        new List<int>{ 0,0,0,2,0,0},
        new List<int>{ 0,0,1,2,4,0},
    }));

static int hourglassSum(List<List<int>> arr)
{
    var tempArr = new List<List<int>>();
    var values = new List<int>();
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            tempArr.Add(new List<int>
            {
                arr[i][j], arr[i][j+1],arr[i][j+2],
            });
            tempArr.Add(new List<int>
            {
                0, arr[i+1][j+1],0,
            });
            tempArr.Add(new List<int>
            {
                arr[i+2][j], arr[i+2][j+1],arr[i+2][j+2],
            });
            values.Add(CalculateHourGlass(tempArr));
            tempArr.Clear();
        }
    }

    return values.Max();
}

static int CalculateHourGlass(List<List<int>> arr)
{
    var soma = arr[0].Sum();
    soma += arr[1][1];
    soma += arr[2].Sum();
    return soma;
}