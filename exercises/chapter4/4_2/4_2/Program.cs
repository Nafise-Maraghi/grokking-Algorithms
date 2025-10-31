static int RecursiveCount(int[] numbers)
{
	if (numbers.Length == 0)
	{
		return 0;
	}
	return 1 + RecursiveCount(numbers[1..]);
}


RecursiveCount(new int[] { 1, 3, 5, 2 }); // 4