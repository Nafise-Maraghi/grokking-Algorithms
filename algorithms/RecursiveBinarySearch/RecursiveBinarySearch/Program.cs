static int RecursiveBinarySearch(int item, int[] numbers)
{
	int low = 0;
	int high = numbers.Length - 1;
	int mid = (low + high) / 2;

	if (low > high)
	{
		return -1;
	}

	if (item > numbers[mid])
	{
		low = mid + 1;
	}
	else if (item < numbers[mid])
	{
		high = mid - 1;
	}
	else
	{
		return mid;
	}

	return RecursiveBinarySearch(item, numbers[low..(high + 1)]) + low;
}

Console.WriteLine(RecursiveBinarySearch(12, Enumerable.Range(1, 10).ToArray())); // -1
Console.WriteLine(RecursiveBinarySearch(43, Enumerable.Range(0, 100).ToArray())); // 43
Console.WriteLine(RecursiveBinarySearch(3, new int[] {1, 3, 5, 7})); // 1