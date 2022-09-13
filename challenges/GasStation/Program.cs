int GasStation(int[] gas, int[] cost)
{
	if (gas.Sum() < cost.Sum())
		return - 1;
	
	var gasQtt = 0;
	var answer = 0;
	for (var i = 0; i < gas.Length; i++)
	{
		if (gasQtt + gas[i] - cost[i] < 0)
		{
			gasQtt = 0;
			answer = i++;
			continue;
		}
		
		gasQtt = gasQtt + gas[i] - cost[i];
	}
}
/*
	gasQtt = 6; i=8
	
*/