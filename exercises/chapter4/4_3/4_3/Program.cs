static int RecursiveMax(int[] numbers)
{
	if (numbers.Length == 1)
	{
		return numbers[0];
	}

	int nextMax = RecursiveMax(numbers[1..]);
	
	if (numbers[0] > nextMax)
	{
		return numbers[0];
	}
	return nextMax;
}


RecursiveMax(new int[] { 1, 3, 5, 2 }); // 5