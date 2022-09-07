Console.WriteLine(truckTour(new List<List<int>> {
    new List<int>() { 4, 6,} ,
    new List<int>() { 6, 5} ,
    new List<int>() { 7, 3,},
    new List<int>() { 4, 5,}
}));

static int truckTour(List<List<int>> petrolpumps)
{
    var position = 0;
    var fuel = 0;

    for (int i = 0; i < petrolpumps.Count; i++)
    {
        var currentFuel = petrolpumps[i][0];
        var next = petrolpumps[i][1];
        fuel += currentFuel - next;
        if (fuel < 0)
        {
            position = i + 1;
            fuel = 0;
        }
    }

    return position;
}