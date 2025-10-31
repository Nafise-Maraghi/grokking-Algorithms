static int RecursiveSum(int[] numbers)
{
	if (numbers.Length == 0)
	{
		return 0;
	}
	return numbers[0] + RecursiveSum(numbers[1..]);
}


RecursiveSum(new int[] { 1, 3, 5, 2}); // 11